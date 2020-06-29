using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2056)]
    [Attributes(9)]
    public sealed class Wcdma800TxLinMaster3
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}