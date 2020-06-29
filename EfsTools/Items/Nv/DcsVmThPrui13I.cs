using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2469)]
    [Attributes(9)]
    public sealed class DcsVmThPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}