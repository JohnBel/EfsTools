using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020496", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma800TxLimVsFreqMtd
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}