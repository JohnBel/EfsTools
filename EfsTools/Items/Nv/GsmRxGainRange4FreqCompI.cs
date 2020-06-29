using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(729)]
    [Attributes(9)]
    public sealed class GsmRxGainRange4FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}