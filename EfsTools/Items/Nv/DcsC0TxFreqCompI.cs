using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2320)]
    [Attributes(9)]
    public sealed class DcsC0TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}