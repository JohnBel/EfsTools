using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025202", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20BandedgeMaxpowerPaBackoff
    {
        public byte Enable { get; set; }


        public byte LowerbandPaSwitchptBackoff { get; set; }


        public byte UpperbandPaSwitchptBackoff { get; set; }
    }
}