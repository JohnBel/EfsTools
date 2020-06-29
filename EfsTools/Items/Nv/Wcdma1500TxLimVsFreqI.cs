using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6949)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLimVsFreq
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}