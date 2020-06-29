using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023184", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21C1RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}