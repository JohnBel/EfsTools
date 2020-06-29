using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6558)]
    [Attributes(9)]
    public sealed class LteB7PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}