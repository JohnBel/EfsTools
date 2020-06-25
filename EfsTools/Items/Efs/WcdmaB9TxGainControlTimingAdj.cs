using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021599", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB9TxGainControlTimingAdj
    {
        public int Value { get; set; }
    }
}