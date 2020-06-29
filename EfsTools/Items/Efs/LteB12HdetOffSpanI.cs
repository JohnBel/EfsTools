using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022171", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}