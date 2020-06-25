using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class TxLinearizerIndexRev2Type
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public QmslTxCalMultiLinearizerIndexNodeRev2NvType[] NodeType
        {
            get;
        }
    }
}