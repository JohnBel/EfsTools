using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024271", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}