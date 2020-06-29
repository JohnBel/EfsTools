using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025477", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB28MaxTxPowerDb10
    {
        [FieldCount(2)]
        public ushort[] MaxTxPowerNvDb10 { get; set; }
    }
}