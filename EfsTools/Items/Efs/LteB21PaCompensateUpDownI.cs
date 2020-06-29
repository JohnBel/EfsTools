using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023152", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}