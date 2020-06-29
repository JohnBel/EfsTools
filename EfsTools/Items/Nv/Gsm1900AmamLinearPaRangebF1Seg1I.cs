using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5639)]
    [Attributes(9)]
    public sealed class Gsm1900AmamLinearPaRangebF1Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}