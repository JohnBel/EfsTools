using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5635)]
    [Attributes(9)]
    public sealed class Gsm1800AmamLinearPaRangebF3Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}