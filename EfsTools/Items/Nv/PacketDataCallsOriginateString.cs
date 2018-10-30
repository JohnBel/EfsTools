using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(298)]
    [Attributes(9)]
    public class PacketDataCallsOriginateString
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field2 { get; set; }

        public string Field2String
        {
            get => StringUtils.GetString(Field2);
            set => Field2 = StringUtils.GetBytes(value, 16);
        }
    }
}