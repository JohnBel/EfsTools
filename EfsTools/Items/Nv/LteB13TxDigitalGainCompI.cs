using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6516)]
    [Attributes(9)]
    public sealed class LteB13TxDigitalGainComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}