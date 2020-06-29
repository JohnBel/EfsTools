using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5646)]
    [Attributes(9)]
    public sealed class Gsm1900AmamLinearPaRangeaF3Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}