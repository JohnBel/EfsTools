using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021652", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB41DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}