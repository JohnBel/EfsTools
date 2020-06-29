using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(760)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex05
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}