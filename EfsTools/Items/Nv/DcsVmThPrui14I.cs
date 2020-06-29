using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2468)]
    [Attributes(9)]
    public sealed class DcsVmThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}