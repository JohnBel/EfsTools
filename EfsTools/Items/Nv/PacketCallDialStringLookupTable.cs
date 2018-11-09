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
        public byte[] DialString1 { get; set; }

        public string DialString1String
        {
            get => StringUtils.GetString(DialString1);
            set => DialString1 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort CallType1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ModesPermitted1 { get; set; }


        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DialString2 { get; set; }

        public string DialString2String
        {
            get => StringUtils.GetString(DialString2);
            set => DialString2 = StringUtils.GetBytes(value, 5);
        }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort CallType2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ModesPermitted2 { get; set; }

        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DialString3 { get; set; }

        public string DialString3String
        {
            get => StringUtils.GetString(DialString3);
            set => DialString3 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort CallType3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ModesPermitted3 { get; set; }

        [JsonIgnore]
        [ElementsCount(5)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] DialString4 { get; set; }

        public string DialString4String
        {
            get => StringUtils.GetString(DialString4);
            set => DialString4 = StringUtils.GetBytes(value, 5);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort CallType4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ModesPermitted4 { get; set; }
    }
}