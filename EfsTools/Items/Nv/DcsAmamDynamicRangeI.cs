using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2745)]
    [Attributes(9)]
    public sealed class DcsAmamDynamicRange
    {
        [FieldCount(2)]
        public int[] Value { get; set; }
    }
}