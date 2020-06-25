using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023387", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class RfBcConfigC3
    {
        public ulong Value { get; set; }
    }
}