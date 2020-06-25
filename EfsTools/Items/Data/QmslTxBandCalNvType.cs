using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxBandCalNvType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Reserved
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] TxCalChan
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public QmslTxPaStateCalDataNvType[] TxPaStateCalData
        {
            get;
        }
    }
}