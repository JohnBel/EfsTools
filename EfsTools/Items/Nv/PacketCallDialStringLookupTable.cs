using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(930)]
    [Attributes(9)]
    public class PacketCallDialStringLookupTable
    {
        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field1 { get; set; }

        public string Field1String
        {
            get => StringUtils.GetString(Field1);
            set => Field1 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field2 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field3 { get; set; }


        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field4 { get; set; }

        public string Field4String
        {
            get => StringUtils.GetString(Field4);
            set => Field4 = StringUtils.GetBytes(value, 5);
        }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field6 { get; set; }

        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field7 { get; set; }

        public string Field7String
        {
            get => StringUtils.GetString(Field7);
            set => Field7 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field9 { get; set; }

        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field10 { get; set; }

        public string Field10String
        {
            get => StringUtils.GetString(Field10);
            set => Field10 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field11 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field12 { get; set; }
    }
}