using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    public static class NvItemIdAttributeUtils
    {
        public static NvItemIdAttribute Get(Type type)
        {
            return (NvItemIdAttribute)type.GetCustomAttributes(typeof(NvItemIdAttribute)).FirstOrDefault();
        }
    }
}
