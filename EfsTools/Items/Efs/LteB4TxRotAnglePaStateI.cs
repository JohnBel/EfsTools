using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020099", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB4TxRotAnglePaState
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}