using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022713", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40TxRotAnglePaState
    {
        [FieldCount(4)]
        public ushort[] Value { get; set; }
    }
}