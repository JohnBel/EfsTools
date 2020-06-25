using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(726)]
    [Attributes(9)]
    public sealed class GsmRxGainRange1FreqComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] Value { get; set; }
    }
}