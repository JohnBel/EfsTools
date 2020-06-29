using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxPwrLimitDataType
    {
        public byte Bw { get; set; }


        public ushort CarrierConfigPattern { get; set; }


        public ushort LowestFreqChan { get; set; }


        public ushort HighestFreqChan { get; set; }

        [FieldCount(8)]
        public short[] TxPwrLimitDbm10
        {
            get;
        }

        [FieldCount(7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] HiBackoffLut
        {
            get;
        }

        [FieldCount(7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] LoBackoffLut
        {
            get;
        }


        public byte LutIndicator { get; set; }


        public byte FunnelBias { get; set; }


        public ushort MdspReadingAtReferenceTemperature { get; set; }


        public byte TableVersion { get; set; }

        [FieldCount(3)]
        public byte[] Reserved
        {
            get;
        }
    }
}