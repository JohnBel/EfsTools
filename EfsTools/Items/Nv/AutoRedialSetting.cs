using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(75)]
    [Attributes(9)]
    public class AutoRedialSetting
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Enable { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Rings { get; set; }
    }
}