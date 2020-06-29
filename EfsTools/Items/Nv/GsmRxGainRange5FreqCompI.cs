using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3502)]
    [Attributes(9)]
    public sealed class GsmRxGainRange5FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}