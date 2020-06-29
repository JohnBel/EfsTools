using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2434)]
    [Attributes(9)]
    public sealed class DcsVhTmPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}