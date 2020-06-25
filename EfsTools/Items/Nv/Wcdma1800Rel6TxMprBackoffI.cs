using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5279)]
    [Attributes(9)]
    public sealed class Wcdma1800Rel6TxMprBackoff
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Value { get; set; }
    }
}