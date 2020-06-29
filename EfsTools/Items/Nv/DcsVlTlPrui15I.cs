using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2341)]
    [Attributes(9)]
    public sealed class DcsVlTlPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}