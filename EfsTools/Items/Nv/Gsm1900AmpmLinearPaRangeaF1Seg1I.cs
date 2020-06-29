using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5685)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmLinearPaRangeaF1Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}