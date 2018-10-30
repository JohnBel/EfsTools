using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/ue_based_cw", true, 0xE1FF)]
    [Attributes(9)]
    public class UeBasedCw
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value2 { get; set; }
    }
}