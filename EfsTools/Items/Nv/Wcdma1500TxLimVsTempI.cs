using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6948)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}