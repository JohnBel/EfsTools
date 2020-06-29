using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5479)]
    [Attributes(9)]
    public sealed class EnhTherm
    {
        [FieldCount(2)]
        public uint[] Value { get; set; }
    }
}