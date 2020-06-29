using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2218)]
    [Attributes(9)]
    public sealed class DcsVlTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}