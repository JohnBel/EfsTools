using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020067", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}