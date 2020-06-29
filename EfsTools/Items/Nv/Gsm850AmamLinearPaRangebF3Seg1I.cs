using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5611)]
    [Attributes(9)]
    public sealed class Gsm850AmamLinearPaRangebF3Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}