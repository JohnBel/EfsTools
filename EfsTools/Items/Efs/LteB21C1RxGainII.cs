using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024201", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21C1RxGainI
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}