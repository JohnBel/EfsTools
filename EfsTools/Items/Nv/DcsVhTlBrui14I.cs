using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2200)]
    [Attributes(9)]
    public sealed class DcsVhTlBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}