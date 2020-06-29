using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6507)]
    [Attributes(9)]
    public sealed class LteB13PaCompensateUpDown
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}