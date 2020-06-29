using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2345)]
    [Attributes(9)]
    public sealed class DcsVlTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}