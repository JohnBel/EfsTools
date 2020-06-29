using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2219)]
    [Attributes(9)]
    public sealed class DcsVlTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}