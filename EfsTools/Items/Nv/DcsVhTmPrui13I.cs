using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2433)]
    [Attributes(9)]
    public sealed class DcsVhTmPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}