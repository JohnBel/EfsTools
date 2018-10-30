using System;
using System.Linq;
using System.Reflection;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class EfsFileAttributeUtils
    {
        public static EfsFileAttribute Get(Type type)
        {
            return (EfsFileAttribute) type.GetCustomAttributes(typeof(EfsFileAttribute)).FirstOrDefault();
        }
    }
}