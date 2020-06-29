using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2163)]
    [Attributes(9)]
    public sealed class DcsVlTlBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}