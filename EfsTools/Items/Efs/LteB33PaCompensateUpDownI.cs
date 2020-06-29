using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024861", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] PaCompensateUpDownType { get; set; }
    }
}