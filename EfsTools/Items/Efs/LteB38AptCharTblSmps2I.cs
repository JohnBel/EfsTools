using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021519", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38AptCharTblSmps2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}