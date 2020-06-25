using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxCalCompleteNvType
    {
        public QmslTxBandCalNvType BandCalData { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }
    }
}