using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020858", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}