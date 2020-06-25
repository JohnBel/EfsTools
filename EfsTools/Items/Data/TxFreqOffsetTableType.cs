using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class TxFreqOffsetTableType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public QmslTxCalFreqOffsetRowNvType[] Row
        {
            get;
        }
    }
}