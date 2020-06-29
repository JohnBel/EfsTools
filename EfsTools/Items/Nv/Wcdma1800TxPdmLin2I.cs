using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3993)]
    [Attributes(9)]
    public sealed class Wcdma1800TxPdmLin2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}