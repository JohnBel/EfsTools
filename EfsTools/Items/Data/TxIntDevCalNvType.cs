using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class TxIntDevCalNvType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] CdmaBcTxIntCal
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] GsmBcTxIntCal
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] WcdmaBcTxIntCal
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] LteBcTxIntCal
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] TdscdmaBcTxIntCal
        {
            get;
        }
    }
}