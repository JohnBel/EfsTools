using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4163)]
    [Attributes(9)]
    public sealed class Wcdma1900Iaccum
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] Value { get; set; }
    }
}