using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4946)]
    [Attributes(9)]
    public sealed class Wcdma1900Rel6TxMprBackoff
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}