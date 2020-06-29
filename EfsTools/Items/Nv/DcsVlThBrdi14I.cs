using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2275)]
    [Attributes(9)]
    public sealed class DcsVlThBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}