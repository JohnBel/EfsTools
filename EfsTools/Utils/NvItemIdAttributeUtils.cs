using System;
using System.Linq;
using System.Reflection;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class NvItemIdAttributeUtils
    {
        public static NvItemIdAttribute Get(Type type)
        {
            return (NvItemIdAttribute) type.GetCustomAttributes(typeof(NvItemIdAttribute)).FirstOrDefault();
        }
    }
}