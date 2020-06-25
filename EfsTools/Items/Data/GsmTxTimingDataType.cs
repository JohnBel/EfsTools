using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmTxTimingDataType
    {
        public short TxBurstOffsetAdj { get; set; }


        public short PaEnStartOffsetAdj { get; set; }


        public short PaEnStopOffsetAdj { get; set; }


        public short PaStartOffsetAdj { get; set; }


        public short PaStopOffsetAdj { get; set; }


        public short AntTimingStartOffsetAdj { get; set; }


        public short AntTimingStopOffsetAdj { get; set; }
    }
}