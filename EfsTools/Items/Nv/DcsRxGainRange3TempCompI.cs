using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4383)]
    [Attributes(9)]
    public sealed class DcsRxGainRange3TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}