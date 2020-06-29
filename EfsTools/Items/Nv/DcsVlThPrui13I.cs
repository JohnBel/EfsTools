using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2451)]
    [Attributes(9)]
    public sealed class DcsVlThPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}