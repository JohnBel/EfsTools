using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2346)]
    [Attributes(9)]
    public sealed class DcsVlTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}