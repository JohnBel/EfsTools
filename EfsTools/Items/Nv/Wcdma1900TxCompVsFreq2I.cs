using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2032)]
    [Attributes(9)]
    public sealed class Wcdma1900TxCompVsFreq2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public sbyte[] Value { get; set; }
    }
}