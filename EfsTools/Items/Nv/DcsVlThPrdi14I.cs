using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2453)]
    [Attributes(9)]
    public sealed class DcsVlThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}