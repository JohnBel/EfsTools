using System;
using System.IO;
using BinarySerialization;
using EfsTools.Items.Base;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Base
{
    [Serializable]
    public class MultiLineStringsItemBase : ItemBase, IBinarySerializable
    {
        [Ignore]
        public string[] Values
        {
            get; set;
        }

  
        public void Serialize(Stream stream, Endianness endianness, BinarySerializationContext serializationContext)
        {
            if (Values != null)
            {
                using var writer = new StreamWriter(stream);
                var txt = StringUtils.GetString(Values, LineEnding.Linux);
                writer.Write(txt);
                writer.Flush();
                writer.Close();
            }
        }

        public void Deserialize(Stream stream, Endianness endianness, BinarySerializationContext serializationContext)
        {
            using var reader = new StreamReader(stream);
            var txt = reader.ReadToEnd();
            Values = StringUtils.GetStringLines(txt,LineEnding.Linux);
        }
    }
}