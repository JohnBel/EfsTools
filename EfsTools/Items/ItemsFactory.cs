using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EfsTools.Utils;

namespace EfsTools.Items
{
    public static class ItemsFactory
    {
        public static object CreateNvItem(int id)
        {
            InitilaizeNvItemsMetadata();
            if (_nvItemsMetadata.TryGetValue(id, out Type type))
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

        public static object CreateEfsFile(string path)
        {
            InitilaizeEfsFileMetadata();
            if (_efsFileMetadata.TryGetValue(path, out Type type))
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }

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
                            if (nvItemId != null)
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

        private static Dictionary<int, Type> _nvItemsMetadata = new Dictionary<int, Type>();
        private static Dictionary<string, Type> _efsFileMetadata = new Dictionary<string, Type>(StringComparer.InvariantCulture);
    }
}
