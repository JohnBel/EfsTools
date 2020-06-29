using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2379)]
    [Attributes(9)]
    public sealed class DcsVhTlPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}