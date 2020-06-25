using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3061)]
    [Attributes(9)]
    public sealed class Gsm850PowerLevels
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public short[] Value { get; set; }
    }
}