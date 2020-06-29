using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020234", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}