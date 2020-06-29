using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4375)]
    [Attributes(9)]
    public sealed class DcsRxGainRange1TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}