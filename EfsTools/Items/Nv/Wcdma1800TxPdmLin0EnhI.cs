using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5063)]
    [Attributes(9)]
    public sealed class Wcdma1800TxPdmLin0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}