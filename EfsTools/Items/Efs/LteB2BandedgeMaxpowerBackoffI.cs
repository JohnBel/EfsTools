using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025185", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB2BandedgeMaxpowerBackoff
    {
        public byte Enable { get; set; }


        public byte LowerbandBackoff { get; set; }


        public byte UpperbandBackoff { get; set; }
    }
}