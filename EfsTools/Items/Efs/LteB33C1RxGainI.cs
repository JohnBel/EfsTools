using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024891", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1RxGain
    {
        [FieldCount(16)]
        public short[] C1RxGain { get; set; }
    }
}