using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022704", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40MaxTxPower
    {
        public short Value { get; set; }
    }
}