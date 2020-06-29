using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025342", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21C2RxGain
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}