using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023867", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxGtrThresh
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short Reserved { get; set; }
    }
}