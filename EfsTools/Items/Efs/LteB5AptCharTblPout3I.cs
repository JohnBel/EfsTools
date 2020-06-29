using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021428", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB5AptCharTblPout3
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}