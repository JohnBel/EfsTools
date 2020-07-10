using System;
using System.Collections.Generic;
using System.IO;
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
            using (var jsonReader = new JsonTextReader(reader))
            {
                var serializer = JsonSerializer.CreateDefault();

                var jsonObj = (JObject) serializer.Deserialize(jsonReader, typeof(JObject));
                if (jsonObj != null)
                {
                    foreach (var jsonItem in jsonObj)
                    {
                        var type = jsonItem.Key;
                        if (items.TryGetValue(type, out var item))
                        {
                            var data = jsonItem.Value;
                            DeserializeItem(item, data);
                        }
                    }
                }
            }
        }

        private static void DeserializeItem(object item, JToken data)
        {
            var itemType = item.GetType();
            var json = data.ToString();
            //var sourceItem = data.Values();
            foreach (JProperty it in data)
            {
                SetProperty(item, it);
            }
        }

        private static void SetProperty(object obj, JProperty jProperty)
        {
            var type = obj.GetType();
            var propInfo = type.GetProperty(jProperty.Name);
            if (propInfo != null)
            {
                var propType = propInfo.PropertyType;
                if (propType != null)
                {
                    var val = ConvertTo(jProperty.Value, propType);
                    propInfo.SetValue(obj, val);
                }
            }
        }

        private static object ConvertTo(JToken value, Type type)
        {
            object result = value.ToObject(type);
            /*if (value.HasValues)
            {
                result = result;
            }*/
            return result;
        }
    }
}