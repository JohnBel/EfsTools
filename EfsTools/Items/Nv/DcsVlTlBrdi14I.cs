using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2167)]
    [Attributes(9)]
    public sealed class DcsVlTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}