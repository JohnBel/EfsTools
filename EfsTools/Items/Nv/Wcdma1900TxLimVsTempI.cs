using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1183)]
    [Attributes(9)]
    public sealed class Wcdma1900TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}