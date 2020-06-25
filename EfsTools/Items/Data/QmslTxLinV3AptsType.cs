using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxLinV3AptsType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] Apt
        {
            get;
        }
    }
}