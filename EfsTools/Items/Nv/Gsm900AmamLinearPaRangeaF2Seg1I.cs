using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5617)]
    [Attributes(9)]
    public sealed class Gsm900AmamLinearPaRangeaF2Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}