using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025555", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB24TxXptDelay
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