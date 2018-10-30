using System;
using System.Linq;
using System.Reflection;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class IgnoreAttributeUtils
    {
        public static IgnoreAttribute Get(Type type)
        {
            return (IgnoreAttribute) type.GetCustomAttributes(typeof(IgnoreAttribute)).FirstOrDefault();
        }
    }
}