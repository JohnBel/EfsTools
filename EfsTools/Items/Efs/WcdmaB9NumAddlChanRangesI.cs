using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022446", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB9NumAddlChanRanges
    {
        public byte Value { get; set; }
    }
}