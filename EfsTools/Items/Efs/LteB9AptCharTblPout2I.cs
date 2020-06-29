using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023551", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB9AptCharTblPout2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}