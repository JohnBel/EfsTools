using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_wtol_cm_support", true, 0xE1FF)]
    [Attributes(25)]
    public class WcdmaRrcWtolCmSupport
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}