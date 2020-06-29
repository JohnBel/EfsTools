using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2323)]
    [Attributes(9)]
    public sealed class DcsC1TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}