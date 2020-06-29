using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3983)]
    [Attributes(9)]
    public sealed class Wcdma900TxPdmLin2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}