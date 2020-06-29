using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5619)]
    [Attributes(9)]
    public sealed class Gsm900AmamLinearPaRangebF2Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}