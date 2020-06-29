using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2377)]
    [Attributes(9)]
    public sealed class DcsVhTlPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}