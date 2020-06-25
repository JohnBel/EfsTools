using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxPwrLimitDataType
    {
        public byte Bw { get; set; }


        public ushort CarrierConfigPattern { get; set; }


        public ushort LowestFreqChan { get; set; }


        public ushort HighestFreqChan { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] TxPwrLimitDbm10
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] HiBackoffLut
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public QmslTxPwrImbalanceDbm10CoordinateType[] LoBackoffLut
        {
            get;
        }


        public byte LutIndicator { get; set; }


        public byte FunnelBias { get; set; }


        public ushort MdspReadingAtReferenceTemperature { get; set; }


        public byte TableVersion { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved
        {
            get;
        }
    }
}