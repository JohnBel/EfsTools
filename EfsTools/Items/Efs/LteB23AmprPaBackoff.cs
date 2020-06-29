using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024322", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23AmprPaBackoff
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}