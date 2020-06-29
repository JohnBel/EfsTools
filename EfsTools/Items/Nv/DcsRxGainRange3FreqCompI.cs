using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(732)]
    [Attributes(9)]
    public sealed class DcsRxGainRange3FreqComp
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}