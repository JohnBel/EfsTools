using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022224", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}