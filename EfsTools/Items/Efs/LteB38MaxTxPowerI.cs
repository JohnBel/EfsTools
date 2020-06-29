using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020394", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}