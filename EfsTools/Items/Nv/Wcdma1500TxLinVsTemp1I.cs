using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6943)]
    [Attributes(9)]
    public sealed class Wcdma1500TxLinVsTemp1
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}