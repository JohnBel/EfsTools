using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EfsTools.Attributes;
using EfsTools.Items;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EfsTools.Utils
{
    internal static class SubscriptionAttributeUtils
    {
        public static SubscriptionAttribute Get(Type type)
        {
            return (SubscriptionAttribute)type.GetCustomAttributes(typeof(SubscriptionAttribute), true).FirstOrDefault();
        }
    }
}