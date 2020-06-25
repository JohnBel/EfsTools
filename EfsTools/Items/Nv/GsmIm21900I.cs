using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4177)]
    [Attributes(9)]
    public sealed class GsmIm21900
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Value1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Value2 { get; set; }
    }
}