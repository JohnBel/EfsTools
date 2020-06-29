using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4391)]
    [Attributes(9)]
    public sealed class DcsRxGainRange5TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}