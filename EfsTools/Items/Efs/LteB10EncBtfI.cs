using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024049", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10EncBtf
    {
        public int Value { get; set; }
    }
}