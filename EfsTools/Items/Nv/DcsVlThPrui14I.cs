using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2450)]
    [Attributes(9)]
    public sealed class DcsVlThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}