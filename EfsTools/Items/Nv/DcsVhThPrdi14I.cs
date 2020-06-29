using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2489)]
    [Attributes(9)]
    public sealed class DcsVhThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}