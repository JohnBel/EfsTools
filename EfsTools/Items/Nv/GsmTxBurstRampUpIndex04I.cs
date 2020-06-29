using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(744)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex04
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}