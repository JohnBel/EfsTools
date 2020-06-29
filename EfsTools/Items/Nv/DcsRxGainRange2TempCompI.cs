using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4379)]
    [Attributes(9)]
    public sealed class DcsRxGainRange2TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}