using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024738", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteMinTxPowerDb10
    {
        public ushort Enable { get; set; }


        public ushort Value { get; set; }
    }
}