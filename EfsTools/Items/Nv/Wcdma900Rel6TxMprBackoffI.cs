using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5276)]
    [Attributes(9)]
    public sealed class Wcdma900Rel6TxMprBackoff
    {
        [FieldCount(7)]
        public byte[] Value { get; set; }
    }
}