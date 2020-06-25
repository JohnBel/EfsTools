using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxCalLinearizerTableNvType
    {
        public ushort TxChain { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ushort[] Rgi
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public short[] Power
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] Apt
        {
            get;
        }
    }
}