using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(311)]
    [Attributes(9)]
    public sealed class FmHdetAdcRange
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Value { get; set; }
    }
}