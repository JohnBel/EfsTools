using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023828", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2TxGtrThresh
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvanceTime { get; set; }
    }
}