using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024079", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}