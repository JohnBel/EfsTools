using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025538", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB7TxXptDelay
    {
        public byte NumActiveEntries { get; set; }

        [FieldCount(16)]
        public ushort[] UpperBoundChannels { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw5mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw10mhz { get; set; }

        [FieldCount(16)]
        public int[] DelayLtebw20mhz { get; set; }
    }
}