using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2488)]
    [Attributes(9)]
    public sealed class DcsVhThPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}