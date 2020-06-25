using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021598", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB8TxGainControlTimingAdj
    {
        public int Value { get; set; }
    }
}