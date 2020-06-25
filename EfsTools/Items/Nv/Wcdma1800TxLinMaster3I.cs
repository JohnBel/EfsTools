using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2876)]
    [Attributes(9)]
    public sealed class Wcdma1800TxLinMaster3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public ushort[] Value { get; set; }
    }
}