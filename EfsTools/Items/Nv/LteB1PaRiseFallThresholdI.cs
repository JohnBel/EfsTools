using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6719)]
    [Attributes(9)]
    public sealed class LteB1PaRiseFallThreshold
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}