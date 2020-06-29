using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6712)]
    [Attributes(9)]
    public sealed class LteB1AgcTxOnRiseFallDelay
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}