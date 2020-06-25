using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024826", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaPartialB40Control
    {
        public byte PartialBandEnabled { get; set; }
    }
}