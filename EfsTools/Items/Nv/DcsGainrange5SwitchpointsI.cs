using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3506)]
    [Attributes(9)]
    public sealed class DcsGainrange5Switchpoints
    {
        [FieldCount(2)]
        public sbyte[] Value { get; set; }
    }
}