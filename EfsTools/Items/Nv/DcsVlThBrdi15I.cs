using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2274)]
    [Attributes(9)]
    public sealed class DcsVlThBrdi15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}