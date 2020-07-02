using System;
using System.Linq;
using System.Reflection;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class IgnoreItemAttributeUtils
    {
        public static IgnoreItemAttribute Get(Type type)
        {
            return (IgnoreItemAttribute) type.GetCustomAttributes(typeof(IgnoreItemAttribute)).FirstOrDefault();
        }
    }
}