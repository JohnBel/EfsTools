using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(194)]
    [Attributes(9)]
    public sealed class FmAgc
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}