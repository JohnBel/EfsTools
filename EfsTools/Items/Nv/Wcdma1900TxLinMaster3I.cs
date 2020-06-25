using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2031)]
    [Attributes(9)]
    public sealed class Wcdma1900TxLinMaster3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public ushort[] Value { get; set; }
    }
}