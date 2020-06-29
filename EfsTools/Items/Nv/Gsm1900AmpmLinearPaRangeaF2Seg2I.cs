using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5690)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmLinearPaRangeaF2Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}