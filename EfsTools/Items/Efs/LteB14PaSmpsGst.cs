using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024416", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB14PaSmpsGst
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}