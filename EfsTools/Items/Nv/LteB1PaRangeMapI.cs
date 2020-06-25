using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6717)]
    [Attributes(9)]
    public sealed class LteB1PaRangeMap
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public sbyte[] Value { get; set; }
    }
}