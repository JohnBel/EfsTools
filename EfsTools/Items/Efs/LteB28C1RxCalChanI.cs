using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025731", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] C1RxCalChan { get; set; }
    }
}