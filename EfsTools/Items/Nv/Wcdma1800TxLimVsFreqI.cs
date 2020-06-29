using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2892)]
    [Attributes(9)]
    public sealed class Wcdma1800TxLimVsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}