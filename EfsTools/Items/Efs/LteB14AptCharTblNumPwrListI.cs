using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024431", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB14AptCharTblNumPwrList
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}