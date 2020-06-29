using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2878)]
    [Attributes(9)]
    public sealed class Wcdma1800TxCompVsFreq1
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}