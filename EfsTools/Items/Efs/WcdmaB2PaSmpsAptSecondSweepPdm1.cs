using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021699", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2PaSmpsAptSecondSweepPdm1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}