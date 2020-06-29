using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6511)]
    [Attributes(9)]
    public sealed class LteB13PaRiseFallThreshold
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}