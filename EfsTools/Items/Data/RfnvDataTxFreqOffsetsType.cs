using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataTxFreqOffsetsType
    {
        public byte PaState { get; set; }


        public byte FcompSweepType { get; set; }


        public ushort FcompIndex { get; set; }


        public QmslTxCalFreqOffsetsType FreqOffsets { get; set; }
    }
}