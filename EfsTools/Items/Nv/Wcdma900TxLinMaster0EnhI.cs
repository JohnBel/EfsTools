using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5055)]
    [Attributes(9)]
    public sealed class Wcdma900TxLinMaster0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}