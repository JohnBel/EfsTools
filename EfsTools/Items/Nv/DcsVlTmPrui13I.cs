using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2397)]
    [Attributes(9)]
    public sealed class DcsVlTmPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}