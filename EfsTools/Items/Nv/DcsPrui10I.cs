using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2119)]
    [Attributes(9)]
    public sealed class DcsPrui10
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}