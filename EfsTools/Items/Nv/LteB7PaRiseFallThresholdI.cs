using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6562)]
    [Attributes(9)]
    public sealed class LteB7PaRiseFallThreshold
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}