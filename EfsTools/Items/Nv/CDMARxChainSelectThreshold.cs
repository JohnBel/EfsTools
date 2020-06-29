using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3515)]
    [Attributes(9)]
    public sealed class CdmaRxChainSelectThreshold
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}