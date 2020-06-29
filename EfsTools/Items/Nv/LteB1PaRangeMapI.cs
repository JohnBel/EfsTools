using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6717)]
    [Attributes(9)]
    public sealed class LteB1PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}