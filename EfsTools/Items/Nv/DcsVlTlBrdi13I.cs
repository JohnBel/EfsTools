using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2168)]
    [Attributes(9)]
    public sealed class DcsVlTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}