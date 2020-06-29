using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2364)]
    [Attributes(9)]
    public sealed class DcsVmTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}