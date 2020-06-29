using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2183)]
    [Attributes(9)]
    public sealed class DcsVmTlBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}