using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021595", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2TxGainControlTimingAdj
    {
        public int Value { get; set; }
    }
}