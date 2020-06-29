using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2435)]
    [Attributes(9)]
    public sealed class DcsVhTmPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}