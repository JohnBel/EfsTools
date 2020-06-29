using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2199)]
    [Attributes(9)]
    public sealed class DcsVhTlBrui15
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}