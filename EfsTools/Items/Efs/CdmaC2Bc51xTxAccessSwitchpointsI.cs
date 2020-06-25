using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021898", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc51xTxAccessSwitchpoints
    {
        public short G1G0Fall { get; set; }


        public short G0G1Rise { get; set; }


        public short G2G1Fall { get; set; }


        public short G1G2Rise { get; set; }


        public short G3G2Fall { get; set; }


        public short G2G3Rise { get; set; }


        public short FallTimeHyst { get; set; }
    }
}