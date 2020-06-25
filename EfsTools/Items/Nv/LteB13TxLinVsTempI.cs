using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6508)]
    [Attributes(9)]
    public sealed class LteB13TxLinVsTemp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public sbyte[] Value { get; set; }
    }
}