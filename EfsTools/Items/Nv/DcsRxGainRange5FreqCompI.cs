using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3503)]
    [Attributes(9)]
    public sealed class DcsRxGainRange5FreqComp
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}