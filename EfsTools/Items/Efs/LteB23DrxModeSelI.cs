using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024311", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}