using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5677)]
    [Attributes(9)]
    public sealed class Gsm1800AmpmLinearPaRangeaF2Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}