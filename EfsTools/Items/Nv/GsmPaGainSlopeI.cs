using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(802)]
    [Attributes(9)]
    public sealed class GsmPaGainSlope
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public byte[] Value { get; set; }
    }
}