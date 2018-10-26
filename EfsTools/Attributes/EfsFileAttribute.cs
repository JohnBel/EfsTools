using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Path { get; private set; }
        public bool IsItemFile { get; private set; }
        public int Permissions { get; private set; }
    }
}
