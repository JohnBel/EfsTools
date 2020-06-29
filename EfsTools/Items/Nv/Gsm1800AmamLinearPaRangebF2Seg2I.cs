using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5632)]
    [Attributes(9)]
    public sealed class Gsm1800AmamLinearPaRangebF2Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}