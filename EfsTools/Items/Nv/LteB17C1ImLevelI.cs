using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6638)]
    [Attributes(9)]
    public sealed class LteB17C1ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}