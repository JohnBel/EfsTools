using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(726)]
    [Attributes(9)]
    public sealed class GsmRxGainRange1FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}