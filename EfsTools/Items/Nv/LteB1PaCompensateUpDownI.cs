using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6715)]
    [Attributes(9)]
    public sealed class LteB1PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}