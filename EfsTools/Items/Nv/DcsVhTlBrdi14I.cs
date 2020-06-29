using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2203)]
    [Attributes(9)]
    public sealed class DcsVhTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}