using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024844", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33RxCalChan
    {
        [FieldCount(16)]
        public ushort[] RxCalChan { get; set; }
    }
}