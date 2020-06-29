using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5688)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmLinearPaRangebF1Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}