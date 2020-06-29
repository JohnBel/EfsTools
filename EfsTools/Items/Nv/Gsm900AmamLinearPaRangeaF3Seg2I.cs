using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5622)]
    [Attributes(9)]
    public sealed class Gsm900AmamLinearPaRangeaF3Seg2
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}