using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022465", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB4NumAddlChanRanges
    {
        public byte Value { get; set; }
    }
}