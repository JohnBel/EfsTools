using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6621)]
    [Attributes(9)]
    public sealed class LteB17TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}