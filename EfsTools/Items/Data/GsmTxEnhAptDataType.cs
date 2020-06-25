using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxEnhAptDataType
    {
        public byte PclThresholdVal { get; set; }


        public ushort VbattThresholdLowPwr { get; set; }


        public ushort VbattThresholdHighPwr { get; set; }
    }
}