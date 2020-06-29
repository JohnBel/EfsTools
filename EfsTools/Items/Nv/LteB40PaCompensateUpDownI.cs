using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6663)]
    [Attributes(9)]
    public sealed class LteB40PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}