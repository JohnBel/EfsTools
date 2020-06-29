using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022428", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2ChanRange1Def
    {
        [FieldCount(3)]
        public ushort[] Value { get; set; }
    }
}