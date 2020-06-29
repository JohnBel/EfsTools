using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025277", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6C2RxGain
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}