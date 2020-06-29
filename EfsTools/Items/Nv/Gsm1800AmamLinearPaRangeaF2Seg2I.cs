using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5630)]
    [Attributes(9)]
    public sealed class Gsm1800AmamLinearPaRangeaF2Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}