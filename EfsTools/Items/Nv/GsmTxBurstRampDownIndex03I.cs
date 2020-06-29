using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(758)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex03
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}