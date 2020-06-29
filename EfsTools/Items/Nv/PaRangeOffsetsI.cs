using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(410)]
    [Attributes(9)]
    public sealed class PaRangeOffsets
    {
        [FieldCount(4)]
        public short[] Value { get; set; }
    }
}