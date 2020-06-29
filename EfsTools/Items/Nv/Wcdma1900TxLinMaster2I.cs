using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2030)]
    [Attributes(9)]
    public sealed class Wcdma1900TxLinMaster2
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}