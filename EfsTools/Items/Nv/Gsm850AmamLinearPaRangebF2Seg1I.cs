using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5607)]
    [Attributes(9)]
    public sealed class Gsm850AmamLinearPaRangebF2Seg1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}