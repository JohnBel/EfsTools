using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(730)]
    [Attributes(9)]
    public sealed class DcsRxGainRange1FreqComp
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}