using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5621)]
    [Attributes(9)]
    public sealed class Gsm900AmamLinearPaRangeaF3Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}