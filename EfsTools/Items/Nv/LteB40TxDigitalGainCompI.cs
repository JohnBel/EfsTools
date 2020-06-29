using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6672)]
    [Attributes(9)]
    public sealed class LteB40TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}