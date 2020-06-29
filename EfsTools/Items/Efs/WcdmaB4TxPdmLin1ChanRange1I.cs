using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022471", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB4TxPdmLin1ChanRange1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}