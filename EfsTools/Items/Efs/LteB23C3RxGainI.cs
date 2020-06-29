using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025350", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23C3RxGain
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}