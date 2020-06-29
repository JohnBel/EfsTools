using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(727)]
    [Attributes(9)]
    public sealed class GsmRxGainRange2FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}