using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref_extn_65_256", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteBandPreferenceExtn65
    {
        public LteBandPreferenceExtn65()
        {
            Value = new byte[24];
        }

        [FieldCount(24)]
        public byte[] Value { get; set; }
    }
}