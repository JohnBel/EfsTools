using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5642)]
    [Attributes(9)]
    public sealed class Gsm1900AmamLinearPaRangeaF2Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}