using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5602)]
    [Attributes(9)]
    public sealed class Gsm850AmamLinearPaRangeaF1Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}