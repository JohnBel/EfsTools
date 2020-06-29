using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6567)]
    [Attributes(9)]
    public sealed class LteB7TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}