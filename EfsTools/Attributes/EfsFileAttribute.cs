using System;

namespace EfsTools.Attributes
{
    public class EfsFileAttribute : Attribute
    {
        public EfsFileAttribute(string path, bool isItemFile, int permissions)
        {
            Path = path;
            IsItemFile = isItemFile;
            Permissions = permissions;
        }

        public string Path { get; }
        public bool IsItemFile { get; }
        public int Permissions { get; }
    }
}