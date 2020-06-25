using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021597", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB5TxGainControlTimingAdj
    {
        public int Value { get; set; }
    }
}