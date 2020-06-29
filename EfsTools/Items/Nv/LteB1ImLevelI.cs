using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6702)]
    [Attributes(9)]
    public sealed class LteB1ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}