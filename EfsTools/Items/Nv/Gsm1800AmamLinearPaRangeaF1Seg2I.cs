using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5626)]
    [Attributes(9)]
    public sealed class Gsm1800AmamLinearPaRangeaF1Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}