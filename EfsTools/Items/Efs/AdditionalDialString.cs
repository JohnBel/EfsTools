using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/additional_dial_string", true, 0xE1FF)]
    [Attributes(9)]
    public class AdditionalDialString
    {
        [JsonIgnore]
        [ElementsCount(20)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value1 { get; set; }

        public string Value1String
        {
            get => StringUtils.GetString(Value1);
            set => Value1 = StringUtils.GetBytes(value, 20);
        }

        [JsonIgnore]
        [ElementsCount(20)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value2 { get; set; }

        public string Value2String
        {
            get => StringUtils.GetString(Value2);
            set => Value2 = StringUtils.GetBytes(value, 20);
        }
    }
}