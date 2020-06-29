using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024485", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB42HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}