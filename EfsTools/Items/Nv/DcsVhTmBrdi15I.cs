using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2256)]
    [Attributes(9)]
    public sealed class DcsVhTmBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}