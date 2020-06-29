using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2222)]
    [Attributes(9)]
    public sealed class DcsVlTmBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}