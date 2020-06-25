using System;
using System.Linq;
using EfsTools.Attributes;

namespace EfsTools.Utils
{
    internal static class SubscriptionAttributeUtils
    {
        public static SubscriptionAttribute Get(Type type)
        {
            return (SubscriptionAttribute) type.GetCustomAttributes(typeof(SubscriptionAttribute), true)
                .FirstOrDefault();
        }
    }
}