using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6202)]
    [Attributes(9)]
    public sealed class BcxBlock1TxPwrComp3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public sbyte[] Value
        {
            get;
        }
    }
}