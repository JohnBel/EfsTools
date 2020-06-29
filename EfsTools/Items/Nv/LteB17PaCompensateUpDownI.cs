using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6611)]
    [Attributes(9)]
    public sealed class LteB17PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}