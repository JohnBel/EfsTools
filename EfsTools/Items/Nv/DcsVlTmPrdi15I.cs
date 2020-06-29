using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2398)]
    [Attributes(9)]
    public sealed class DcsVlTmPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}