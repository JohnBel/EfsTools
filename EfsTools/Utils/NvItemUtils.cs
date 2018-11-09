using System;
using System.Collections.Generic;
using System.IO;
using EfsTools.Items;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EfsTools.Utils
{
    internal static class NvItemUtils
    {
        public static HashSet<string> GetConfigs(TextReader reader)
        {
            var result = new HashSet<string>();
            var str = reader.ReadToEnd();
            var jsonObj = (JObject) JsonConvert.DeserializeObject(str);

            foreach (var jsonItem in jsonObj)
            {
                var type = jsonItem.Key;
                result.Add(type);
            }

            return result;
        }

        public static Dictionary<string, object> PhoneLoadItems(QcdmManager manager, HashSet<string> configItems)
        {
            var items = new Dictionary<string, object>();
            foreach (var filePath in ItemsFactory.SupportedEfsFilePaths)
            {
                var item = ItemsFactory.CreateEfsFile(filePath);
                var itemType = item.GetType();
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    if (manager.Efs.FileExists(filePath))
                        using (var stream = FileUtils.PhoneOpenRead(manager, filePath))
                        {
                            ItemsBinarySerializer.Deserialize(item, stream);
                            stream.Close();
                        }

                    items.Add(itemType.Name, item);
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var item = ItemsFactory.CreateNvItem(nvItemId);
                var itemType = item.GetType();
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    using (var stream = NvOpenRead(manager, (ushort) nvItemId))
                    {
                        if (stream != null)
                        {
                            ItemsBinarySerializer.Deserialize(item, stream);
                            stream.Close();
                        }
                    }

                    items.Add(itemType.Name, item);
                }
            }

            return items;
        }

        public static Dictionary<string, object> PhoneLoadItems(QcdmManager manager)
        {
            var items = new Dictionary<string, object>();
            foreach (var filePath in ItemsFactory.SupportedEfsFilePaths)
                if (manager.Efs.FileExists(filePath))
                {
                    var item = ItemsFactory.CreateEfsFile(filePath);
                    var itemType = item.GetType();
                    using (var stream = FileUtils.PhoneOpenRead(manager, filePath))
                    {
                        ItemsBinarySerializer.Deserialize(item, stream);
                        stream.Close();
                    }

                    items.Add(itemType.Name, item);
                }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var item = ItemsFactory.CreateNvItem(nvItemId);
                var itemType = item.GetType();
                using (var stream = NvOpenRead(manager, (ushort) nvItemId))
                {
                    if (stream != null)
                    {
                        ItemsBinarySerializer.Deserialize(item, stream);
                        stream.Close();
                        items.Add(itemType.Name, item);
                    }
                }
            }

            return items;
        }

        public static void PhoneSaveItems(QcdmManager manager, Dictionary<string, object> items, Logger logger)
        {
            var efs = manager.Efs;
            foreach (var item in items)
            {
                var type = item.Value.GetType();
                var fileAttribute = EfsFileAttributeUtils.Get(type);
                if (fileAttribute == null)
                {
                    var nvItemIdAttribute = NvItemIdAttributeUtils.Get(type);
                    if (nvItemIdAttribute != null && nvItemIdAttribute.Id <= UInt16.MaxValue)
                    {
                        using (var stream = NvOpenWrite(manager, (ushort) nvItemIdAttribute.Id))
                        {
                            ItemsBinarySerializer.Serialize(item.Value, stream);
                            stream.Flush();
                            stream.Close();
                        }
                    }
                }
                else
                {
                    var path = fileAttribute.Path;
                    var subscriptionPath = PathUtils.GetSubscriptionPath(path, 1);
                    if (efs.FileExists(subscriptionPath))
                        efs.DeleteFile(subscriptionPath);
                    else
                        subscriptionPath = string.Empty;
                    using (var stream = fileAttribute.IsItemFile
                        ? FileUtils.PhoneItemCreateWrite(manager, path, fileAttribute.Permissions, logger)
                        : FileUtils.PhoneCreateWrite(manager, path, fileAttribute.Permissions, logger))
                    {
                        ItemsBinarySerializer.Serialize(item.Value, stream);
                        stream.Flush();
                        stream.Close();
                    }

                    if (!string.IsNullOrEmpty(subscriptionPath))
                        using (var stream = fileAttribute.IsItemFile
                            ? FileUtils.PhoneItemCreateWrite(manager, subscriptionPath, fileAttribute.Permissions,
                                logger)
                            : FileUtils.PhoneCreateWrite(manager, subscriptionPath, fileAttribute.Permissions, logger))
                        {
                            ItemsBinarySerializer.Serialize(item.Value, stream);
                            stream.Flush();
                            stream.Close();
                        }
                }
            }
        }

        public static Dictionary<string, object> LocalLoadItems(string directoryPath, HashSet<string> configItems)
        {
            var items = new Dictionary<string, object>();
            foreach (var fileUnixPath in ItemsFactory.SupportedEfsFilePaths)
            {
                var item = ItemsFactory.CreateEfsFile(fileUnixPath);
                var itemType = item.GetType();
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    var filePath = fileUnixPath.Replace('/', '\\');
                    var fileAttribute = EfsFileAttributeUtils.Get(itemType);
                    var path = fileAttribute == null
                        ? $"{directoryPath}{filePath}"
                        : PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions,
                            fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File, false);
                    if (!File.Exists(path)) path = $"{directoryPath}{filePath}";
                    if (File.Exists(path))
                        using (var stream = FileUtils.LocalOpenRead(path))
                        {
                            ItemsBinarySerializer.Deserialize(item, stream);
                            stream.Close();
                        }

                    items.Add(itemType.Name, item);
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var item = ItemsFactory.CreateNvItem(nvItemId);
                var itemType = item.GetType();
                if (configItems == null || configItems.Contains(itemType.Name))
                {
                    var nvItemFileName = PathUtils.GetNvItemFileName((ushort) nvItemId);
                    var path = Path.Combine(directoryPath, nvItemFileName);
                    if (File.Exists(path))
                        using (var stream = FileUtils.LocalOpenRead(path))
                        {
                            ItemsBinarySerializer.Deserialize(item, stream);
                            stream.Close();
                        }

                    items.Add(itemType.Name, item);
                }
            }

            return items;
        }

        public static Dictionary<string, object> LocalLoadItems(string directoryPath)
        {
            var items = new Dictionary<string, object>();
            foreach (var fileUnixPath in ItemsFactory.SupportedEfsFilePaths)
            {
                var item = ItemsFactory.CreateEfsFile(fileUnixPath);
                var itemType = item.GetType();
                var fileAttribute = EfsFileAttributeUtils.Get(itemType);
                var filePath = fileUnixPath.Replace('/', '\\');
                var path = fileAttribute == null
                    ? $"{directoryPath}{filePath}"
                    : PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions,
                        fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File, false);
                if (!File.Exists(path)) path = $"{directoryPath}{filePath}";
                if (!File.Exists(path)) path = PathUtils.FindFile(path);
                if (File.Exists(path))
                {
                    using (var stream = FileUtils.LocalOpenRead(path))
                    {
                        ItemsBinarySerializer.Deserialize(item, stream);
                        stream.Close();
                    }

                    items.Add(itemType.Name, item);
                }
            }

            foreach (var nvItemId in ItemsFactory.SupportedNvItemIds)
            {
                var item = ItemsFactory.CreateNvItem(nvItemId);
                var itemType = item.GetType();
                var nvItemFileName = PathUtils.GetNvItemFileName((ushort) nvItemId);
                var path = Path.Combine(directoryPath, nvItemFileName);
                if (File.Exists(path))
                {
                    using (var stream = FileUtils.LocalOpenRead(path))
                    {
                        ItemsBinarySerializer.Deserialize(item, stream);
                        stream.Close();
                    }

                    items.Add(itemType.Name, item);
                }
            }

            return items;
        }

        public static void LocalSaveItems(string directoryPath, Dictionary<string, object> items, Logger logger)
        {
            foreach (var item in items)
            {
                var type = item.Value.GetType();
                var fileAttribute = EfsFileAttributeUtils.Get(type);
                if (fileAttribute == null)
                {
                    var nvItemIdAttribute = NvItemIdAttributeUtils.Get(type);
                    if (nvItemIdAttribute != null && nvItemIdAttribute.Id <= UInt16.MaxValue)
                    {
                        var nvItemFileName = PathUtils.GetNvItemFileName((ushort) nvItemIdAttribute.Id);
                        var path = Path.Combine(directoryPath, nvItemFileName);
                        using (var stream = FileUtils.LocalCreateWrite(path))
                        {
                            ItemsBinarySerializer.Serialize(item.Value, stream);
                            stream.Flush();
                            stream.Close();
                        }
                    }
                }
                else
                {
                    var filePath = fileAttribute.Path;
                    var subscriptionPath = PathUtils.GetSubscriptionPath(filePath, 1);
                    subscriptionPath = Path.Combine(directoryPath, subscriptionPath);
                    if (File.Exists(subscriptionPath))
                        File.Delete(subscriptionPath);
                    else
                        subscriptionPath = null;
                    var entryType = fileAttribute.IsItemFile ? DirectoryEntryType.ItemFile : DirectoryEntryType.File;
                    var path = PathUtils.BuildPath(directoryPath, filePath, fileAttribute.Permissions, entryType,
                        false);
                    using (var stream = FileUtils.LocalCreateWrite(path))
                    {
                        ItemsBinarySerializer.Serialize(item.Value, stream);
                        stream.Flush();
                        stream.Close();
                    }

                    if (!string.IsNullOrEmpty(subscriptionPath))
                        using (var stream = FileUtils.LocalCreateWrite(subscriptionPath))
                        {
                            ItemsBinarySerializer.Serialize(item.Value, stream);
                            stream.Flush();
                            stream.Close();
                        }
                }
            }
        }

        public static void PhoneDownloadNvItems(QcdmManager manager, string path, Logger logger)
        {
            logger.LogInfo(string.Format(Strings.QcdmDownloadingNvItems));
            for (ushort nvItemId = 1; nvItemId < ushort.MaxValue; ++nvItemId)
                PhoneDownloadNvItem(manager, path, nvItemId, logger);
        }

        public static void PhoneUploadNvItems(QcdmManager manager, string path, Logger logger)
        {
            logger.LogInfo(string.Format(Strings.QcdmUploadingNvItems));
            for (ushort nvItemId = 1; nvItemId < ushort.MaxValue; ++nvItemId)
                PhoneUploadNvItem(manager, path, nvItemId, logger);
        }

        private static void PhoneDownloadNvItem(QcdmManager manager, string path, ushort nvItemId, Logger logger)
        {
            var filePath = string.Empty;
            try
            {
                filePath = PathUtils.GetNvItemFileName(nvItemId);
                filePath = Path.Combine(path, filePath);
                using (var input = NvOpenRead(manager, nvItemId))
                {
                    using (var output = FileUtils.LocalCreateWrite(filePath))
                    {
                        StreamUtils.Copy(input, output);
                        output.Flush();
                        output.Close();
                    }

                    input.Close();
                }
            }
            catch
            {
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath)) File.Delete(filePath);
            }
        }

        private static void PhoneUploadNvItem(QcdmManager manager, string path, ushort nvItemId, Logger logger)
        {
            try
            {
                var filePath = PathUtils.GetNvItemFileName(nvItemId);
                filePath = Path.Combine(path, filePath);
                if (File.Exists(filePath))
                    using (var input = FileUtils.LocalOpenRead(filePath))
                    {
                        using (var output = NvOpenWrite(manager, nvItemId))
                        {
                            StreamUtils.Copy(input, output);
                            output.Flush();
                            output.Close();
                        }

                        input.Close();
                    }
            }
            catch
            {
            }
        }

        private static Stream NvOpenRead(QcdmManager manager, ushort nvItemId)
        {
            try
            {
                var data = manager.Nv.Read(nvItemId);
                return new MemoryStream(data);
            }
            catch
            {
                return null;
            }
        }

        private static Stream NvOpenWrite(QcdmManager manager, ushort nvItemId)
        {
            try
            {
                return new QcdmManagerNvWriteStreamAdapter(manager, nvItemId);
            }
            catch
            {
                return null;
            }
        }
    }
}