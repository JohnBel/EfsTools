using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxPaSwptDataType
    {
        public ushort PaR1ToR2 { get; set; }


        public ushort PaR2ToR3 { get; set; }


        public ushort PaR3ToR4 { get; set; }


        public ushort PaR2ToR4 { get; set; }


        public ushort EdgePaLoToMid { get; set; }


        public ushort EdgePaMidToHi { get; set; }


        public ushort PaPredistSwpt1 { get; set; }


        public ushort PaPredistSwpt2 { get; set; }
    }
}