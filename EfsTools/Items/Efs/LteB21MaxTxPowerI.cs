using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023147", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}