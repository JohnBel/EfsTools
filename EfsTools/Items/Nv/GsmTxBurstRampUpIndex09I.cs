using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(749)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}