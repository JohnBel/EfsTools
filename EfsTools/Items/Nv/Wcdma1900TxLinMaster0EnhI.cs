using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5058)]
    [Attributes(9)]
    public sealed class Wcdma1900TxLinMaster0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}