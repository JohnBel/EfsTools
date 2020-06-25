using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6613)]
    [Attributes(9)]
    public sealed class LteB17PaRangeMap
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public sbyte[] Value { get; set; }
    }
}