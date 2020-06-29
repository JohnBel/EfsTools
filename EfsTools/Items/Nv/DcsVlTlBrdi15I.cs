using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2166)]
    [Attributes(9)]
    public sealed class DcsVlTlBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}