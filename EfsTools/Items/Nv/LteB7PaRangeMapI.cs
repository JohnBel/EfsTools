using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6560)]
    [Attributes(9)]
    public sealed class LteB7PaRangeMap
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}