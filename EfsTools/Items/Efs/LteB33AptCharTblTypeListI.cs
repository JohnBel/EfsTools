using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024915", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33AptCharTblTypeList
    {
        [FieldCount(4)]
        public uint[] Value { get; set; }
    }
}