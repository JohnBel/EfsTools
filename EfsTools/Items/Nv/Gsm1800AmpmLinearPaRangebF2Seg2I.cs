using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5680)]
    [Attributes(9)]
    public sealed class Gsm1800AmpmLinearPaRangebF2Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}