using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6968)]
    [Attributes(9)]
    public sealed class Wcdma1500TxCompVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}