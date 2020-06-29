using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6665)]
    [Attributes(9)]
    public sealed class LteB40PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}