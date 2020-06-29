using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023995", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6AptCharTblNumPwrList
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}