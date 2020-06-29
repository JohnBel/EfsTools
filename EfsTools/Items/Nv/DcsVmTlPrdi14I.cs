using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2363)]
    [Attributes(9)]
    public sealed class DcsVmTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}