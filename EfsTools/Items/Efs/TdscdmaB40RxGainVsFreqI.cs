using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022702", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40RxGainVsFreq
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}