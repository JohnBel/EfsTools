using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataTxLinV3Type
    {
        public byte PaState { get; set; }


        public byte WaveType { get; set; }


        public uint TxChan { get; set; }


        public uint UpperBoundTxChan { get; set; }


        public QmslTxLinV3RgisType Rgis { get; set; }


        public QmslTxLinV3PwrsType PwrsDb10 { get; set; }


        public QmslTxLinV3AptsType Apts { get; set; }


        public QmslTxLinV3PaCurrentsType Currents { get; set; }


        public QmslTxLinV3IqOffsetsType IqOffsets { get; set; }


        public QmslTxLinV3DpdInfoType DpdInfo { get; set; }


        public QmslTxLinV3FcompIndexType FcompInfo { get; set; }
    }
}