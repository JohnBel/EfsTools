using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6650)]
    [Attributes(9)]
    public sealed class LteB40ImLevel
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}