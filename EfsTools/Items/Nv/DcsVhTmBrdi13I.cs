using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2258)]
    [Attributes(9)]
    public sealed class DcsVhTmBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}