using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2273)]
    [Attributes(9)]
    public sealed class DcsVlThBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}