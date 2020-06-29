using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(92)]
    [Attributes(9)]
    public sealed class FrTempOffset
    {
        [FieldCount(64)]
        public byte[] Value { get; set; }
    }
}