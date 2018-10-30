using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(910)]
    [Attributes(9)]
    public class PppUserId
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Length { get; set; }


        [JsonIgnore]
        [ElementsCount(127)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 127);
        }
    }
}