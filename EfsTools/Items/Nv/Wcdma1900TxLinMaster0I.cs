using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1173)]
    [Attributes(9)]
    public sealed class Wcdma1900TxLinMaster0
    {
        [FieldCount(37)]
        public ushort[] Value { get; set; }
    }
}