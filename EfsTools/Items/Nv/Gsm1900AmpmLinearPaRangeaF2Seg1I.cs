using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5689)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmLinearPaRangeaF2Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}