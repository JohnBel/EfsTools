using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxPaStateCalDataNvType
    {
        public TxFreqOffsetTableType TxFreqOffsets { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public TxLinearizerIndexType[] TxLinearizerIndex
        {
            get;
        }
    }
}