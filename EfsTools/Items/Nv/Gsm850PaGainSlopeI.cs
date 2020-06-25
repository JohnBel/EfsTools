using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1136)]
    [Attributes(9)]
    public sealed class Gsm850PaGainSlope
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public byte[] Value { get; set; }
    }
}