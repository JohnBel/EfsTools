using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4387)]
    [Attributes(9)]
    public sealed class DcsRxGainRange4TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}