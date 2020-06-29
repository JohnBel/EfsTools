using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6598)]
    [Attributes(9)]
    public sealed class LteB17ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}