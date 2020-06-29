using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6724)]
    [Attributes(9)]
    public sealed class LteB1TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}