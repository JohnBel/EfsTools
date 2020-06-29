using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2378)]
    [Attributes(9)]
    public sealed class DcsVhTlPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}