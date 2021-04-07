using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;

namespace EfsTools.WebDAV
{
    internal class EfsFileManager
    {
        public EfsFileManager()
        {

        }

        public static EfsFileManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EfsFileManager();
                }
                return _instance;
            }
        }

        private static EfsFileManager _instance;

        public DirectoryEntry[] GetEntries(QcdmManager manager, string path)
        {
            if (_entries.TryGetValue(path, out DirectoryEntry[] entries))
            {
                return entries;
            }

            if (IsDirectory(manager, path))
            {
                if (_entries.TryGetValue(path, out DirectoryEntry[] entries2))
                {
                    return entries2;
                }

                using (var directory = manager.Efs.OpenDirectory(path))
                {
                    var entries3 = directory.QueryEntries().ToArray();
                    _entries.Add(path, entries3);
                    return entries3;
                }
            }

            return new DirectoryEntry[0];
        }

        public void UpdateEntries(QcdmManager manager, string path)
        {
            if (IsDirectory(manager, path))
            {
                using (var directory = manager.Efs.OpenDirectory(path))
                {
                    var entries = directory.QueryEntries().ToArray();
                    _entries[path] = entries;
                }
            }
        }

        public DirectoryEntry GetEntry(QcdmManager manager, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return new DirectoryEntry(String.Empty, DirectoryEntryType.Link, 0, 0, 0, 0, 0);
            }
            if (path == "/")
            {
                return new DirectoryEntry(path, DirectoryEntryType.Directory, 1, 1, 0, 0, 0);
            }
            var name = Path.GetFileName(path);
            if (_entries.TryGetValue(path, out DirectoryEntry[] entries))
            {
                var entry = entries.FirstOrDefault((directoryEntry => directoryEntry.Name == name));
                if (entry != null)
                {
                    return entry;
                }
            }

            var basePath = GetBaseDirectory(path);
            if (!string.IsNullOrEmpty(basePath) && _entries.TryGetValue(basePath, out DirectoryEntry[] entries2))
            {
                var entry = entries2.FirstOrDefault((directoryEntry => directoryEntry.Name == name));
                if (entry != null)
                {
                    return entry;
                }
            }

            var stat = manager.Efs.FileStat(path);
            if (stat == null)
            {
                return new DirectoryEntry(name,  DirectoryEntryType.Link, 0, 0, 0, 0, 0);
            }

            return new DirectoryEntry(name, DirectoryEntryType.Link,
                stat.Mode, stat.Size, stat.AccessTime, stat.ModifyTime, stat.CreateTime);
        }
        public bool IsDirectory(QcdmManager manager, string path)
        {
            try
            {
                if (path == "/" || _entries.ContainsKey(path))
                {
                    return true;
                }
                var name = Path.GetFileName(path);
                var basePath = GetBaseDirectory(path);
                if (!string.IsNullOrEmpty(basePath) && _entries.TryGetValue(basePath, out DirectoryEntry[] entries))
                {
                    var entry = entries.FirstOrDefault((directoryEntry => directoryEntry.Name == name));
                    if (entry != null)
                    {
                        return entry.EntryType == DirectoryEntryType.Directory;
                    }
                }
            
                using (var directory = manager.Efs.OpenDirectory(path))
                {
                    var entries2 = directory.QueryEntries().ToArray();
                    _entries.Add(path, entries2);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static string GetBaseDirectory(string path)
        {
            if (string.IsNullOrEmpty(path) || path == "/")
            {
                return string.Empty;
            }

            var index = path.LastIndexOf('/');
            if (index == 0)
            {
                return "/";
            }
            return path.Substring(0, index);
        }

        private readonly Dictionary<string, DirectoryEntry[]> _entries =
            new Dictionary<string, DirectoryEntry[]>(StringComparer.Ordinal);
    }
}