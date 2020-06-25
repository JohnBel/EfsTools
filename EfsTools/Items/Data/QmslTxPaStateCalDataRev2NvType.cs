using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxPaStateCalDataRev2NvType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public TxFreqOffsetTableType[] TxFreqOffsets
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public TxLinearizerIndexRev2Type[] TxLinearizerIndex
        {
            get;
        }
    }
}