using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023187", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}