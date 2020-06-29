using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2184)]
    [Attributes(9)]
    public sealed class DcsVmTlBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}