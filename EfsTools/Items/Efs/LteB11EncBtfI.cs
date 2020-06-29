using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020039", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11EncBtf
    {
        public int Value { get; set; }
    }
}