using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020210", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB7C1RxGainI
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}