using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class EfsFileAttributeUtils
    {
        public static EfsFileAttribute Get(Type type)
        {
            return (EfsFileAttribute)type.GetCustomAttributes(typeof(EfsFileAttribute)).FirstOrDefault();
        }
    }
}
