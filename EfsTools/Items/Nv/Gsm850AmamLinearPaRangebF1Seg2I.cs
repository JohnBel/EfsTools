using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5604)]
    [Attributes(9)]
    public sealed class Gsm850AmamLinearPaRangebF1Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}