using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/3gpp2/prereg_backoff_timer_lcp", true, 0xE1FF)]
    [Attributes(9)]
    public class PreregBackoffTimerLcp
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field6 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field7 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field8 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field9 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field10 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Field11 { get; set; }
    }
}