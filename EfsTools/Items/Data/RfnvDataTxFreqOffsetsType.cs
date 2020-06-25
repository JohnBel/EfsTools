using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataTxFreqOffsetsType
    {
        public byte PaState { get; set; }


        public byte FcompSweepType { get; set; }


        public ushort FcompIndex { get; set; }


        public QmslTxCalFreqOffsetsType FreqOffsets { get; set; }
    }
}