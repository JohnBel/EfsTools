using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022455", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB9TxLinMaster3ChanRange1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}