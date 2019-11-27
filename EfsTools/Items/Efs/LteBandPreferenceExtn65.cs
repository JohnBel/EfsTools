using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref_extn_65_256", true, 0xE1FF)]
    [Attributes(9)]
    public class LteBandPreferenceExtn65
    {
        public LteBandPreferenceExtn65()
        {
            Value = new byte[24];
        }

        [ElementsCount(24)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}