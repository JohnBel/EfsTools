using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2361)]
    [Attributes(9)]
    public sealed class DcsVmTlPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}