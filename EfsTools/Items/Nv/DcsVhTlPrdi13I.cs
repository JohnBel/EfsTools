using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2382)]
    [Attributes(9)]
    public sealed class DcsVhTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}