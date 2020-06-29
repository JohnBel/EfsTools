using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022478", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB4TxLinMaster1ChanRange2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}