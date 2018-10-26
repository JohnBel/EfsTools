using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Markup;
using EfsTools.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EfsTools.Items
{
    internal class ItemsJsonSerializerException : Exception
    {
        public ItemsJsonSerializerException(string message)
            : base(message)
        {
        }
    }

    public static class ItemsJsonSerializer
    {
        public static void SerializeItems(Dictionary<string, object> items, TextWriter writer)
        {
            var str = JsonConvert.SerializeObject(items, Formatting.Indented);
            writer.Write(str);
        }

        public static void DeserializeItems(Dictionary<string, object> items, TextReader reader)
        {
            var str = reader.ReadToEnd();
            var jsonObj = (JObject)JsonConvert.DeserializeObject(str);
            foreach (var jsonItem in jsonObj)
            {
                var type = jsonItem.Key;
                if (items.TryGetValue(type, out object item))
                {
                    var data = jsonItem.Value;
                    DeserializeItem(item, data);
                }
            }
        }

        private static void DeserializeItem(object item, JToken data)
        {
            var itemType = item.GetType();
            var json = data.ToString();
            var sourceItem = JsonConvert.DeserializeObject(json, itemType);
            foreach (JProperty it in data)
            {
                var propName = it.Name;
                SetProperty(item, sourceItem, propName);
            }
        }

        private static void SetProperty(object obj, object source, string propName)
        {
            var type = obj.GetType();
            var propInfo = type.GetProperty(propName);
            if (propInfo != null)
            {
                object val = propInfo.GetValue(source);
                propInfo.SetValue(obj, val);
            }
        }
    }
}
