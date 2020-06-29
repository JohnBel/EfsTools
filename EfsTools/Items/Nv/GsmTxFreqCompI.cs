using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(804)]
    [Attributes(9)]
    public sealed class GsmTxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}