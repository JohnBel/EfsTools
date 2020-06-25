using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxGtrThreshDataType
    {
        public sbyte Enable { get; set; }


        public short RiseThresh { get; set; }


        public short FallThresh { get; set; }


        public short AdvTime { get; set; }
    }
}