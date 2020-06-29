using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3691)]
    [Attributes(9)]
    public sealed class Wcdma900TxLimVsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}