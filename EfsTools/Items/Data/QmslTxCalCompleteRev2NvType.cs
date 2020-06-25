using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxCalCompleteRev2NvType
    {
        public QmslTxBandCalRev2NvType BandCalData { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public QmslTxCalLinearizerEptDpdTableNvType[] TxDpdData
        {
            get;
        }
    }
}