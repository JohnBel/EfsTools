using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(728)]
    [Attributes(9)]
    public sealed class GsmRxGainRange3FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}