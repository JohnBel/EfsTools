using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2237)]
    [Attributes(9)]
    public sealed class DcsVmTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}