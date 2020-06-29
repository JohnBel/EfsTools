using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021477", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB17AptCharTblTypeList
    {
        [FieldCount(4)]
        public uint[] Value { get; set; }
    }
}