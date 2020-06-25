using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4166)]
    [Attributes(9)]
    public sealed class Wcdma1800Qaccum
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] Value { get; set; }
    }
}