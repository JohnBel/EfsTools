using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EfsTools.Utils;

namespace EfsTools.Items
{
    public static class ItemsFactory
    {
        private static readonly Dictionary<int, Type> _nvItemsMetadata = new Dictionary<int, Type>();

        private static readonly Dictionary<string, Type> _efsFileMetadata =
            new Dictionary<string, Type>(StringComparer.InvariantCulture);

        public static int[] SupportedNvItemIds
        {
            get
            {
                InitilaizeNvItemsMetadata();
                return _nvItemsMetadata.Keys.ToArray();
            }
        }

        public static string[] SupportedEfsFilePaths
        {
            get
            {
                InitilaizeEfsFileMetadata();
                return _efsFileMetadata.Keys.ToArray();
            }
        }

        public static Type GetNvItemType(int id)
        {
            InitilaizeNvItemsMetadata();
            if (_nvItemsMetadata.TryGetValue(id, out var type))
            {
                return type;
            }
            return null;
        }

        public static object CreateNvItem(int id)
        {
            var type = GetNvItemType(id);
            if (type != null)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        public static Type GetEfsFileType(string path)
        {
            InitilaizeEfsFileMetadata();
            if (_efsFileMetadata.TryGetValue(path, out var type))
            {
                return type;
            }
            return null;
        }

        public static object CreateEfsFile(string path)
        {
            var type = GetEfsFileType(path);
            if (type != null)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        public static bool HasSubscription(string path)
        {
            InitilaizeEfsFileMetadata();
            if (_efsFileMetadata.TryGetValue(path, out var type))
            {
                var attr = SubscriptionAttributeUtils.Get(type);
                if (attr != null)
                {
                    return true;
                }
            }

            return false;
        }

        private static void InitilaizeNvItemsMetadata()
        {
            if (_nvItemsMetadata.Count == 0)
            {
                var assembly = Assembly.GetCallingAssembly();
                foreach (var type in assembly.GetTypes())
                {
                    if (!type.IsAbstract && !type.IsEnum)
                    {
                        var ignore = IgnoreAttributeUtils.Get(type);
                        if (ignore == null)
                        {
                            var nvItemId = NvItemIdAttributeUtils.Get(type);
                            if (nvItemId != null && nvItemId.Id <= ushort.MaxValue)
                            {
                                _nvItemsMetadata.Add(nvItemId.Id, type);
                            }
                        }
                    }
                }
            }
        }


        private static void InitilaizeEfsFileMetadata()
        {
            if (_efsFileMetadata.Count == 0)
            {
                var assembly = Assembly.GetCallingAssembly();
                foreach (var type in assembly.GetTypes())
                {
                    if (!type.IsAbstract && !type.IsEnum)
                    {
                        var ignore = IgnoreAttributeUtils.Get(type);
                        if (ignore == null)
                        {
                            var efsFile = EfsFileAttributeUtils.Get(type);
                            if (efsFile != null)
                            {
                                _efsFileMetadata.Add(efsFile.Path, type);
                            }
                        }
                    }
                }
            }
        }
    }
}