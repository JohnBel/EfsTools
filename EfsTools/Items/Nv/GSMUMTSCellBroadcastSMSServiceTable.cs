using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1014)]
    [Attributes(41)]
    public class GsmUmtsCellBroadcastSmsServiceTable
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Index { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ActiveService { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServiceFrom { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort ServiceTo { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Selected { get; set; }

        [JsonIgnore]
        [ElementsCount(30)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Label { get; set; }

        public string LabelString
        {
            get => StringUtils.GetString(Label);
            set => Label = StringUtils.GetBytes(value, 30);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LabelEncoding { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte BcAlert { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MaxMessages { get; set; }
    }
}