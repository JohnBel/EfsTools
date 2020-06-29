using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2743)]
    [Attributes(9)]
    public sealed class GsmAmamDynamicRange
    {
        [FieldCount(2)]
        public int[] Value { get; set; }
    }
}