using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025732", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB29C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] C1RxCalChan { get; set; }
    }
}