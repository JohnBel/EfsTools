using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020108", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB4TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}