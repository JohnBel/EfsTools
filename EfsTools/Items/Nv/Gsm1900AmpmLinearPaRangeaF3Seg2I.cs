using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5694)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmLinearPaRangeaF3Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}