using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6612)]
    [Attributes(9)]
    public sealed class LteB17TxLinVsTemp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public sbyte[] Value { get; set; }
    }
}