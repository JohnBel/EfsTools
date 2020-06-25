using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022484", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB5NumAddlChanRanges
    {
        public byte Value { get; set; }
    }
}