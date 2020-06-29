using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2452)]
    [Attributes(9)]
    public sealed class DcsVlThPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}