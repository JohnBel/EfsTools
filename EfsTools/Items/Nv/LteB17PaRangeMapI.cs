using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6613)]
    [Attributes(9)]
    public sealed class LteB17PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}