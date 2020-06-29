using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(750)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex10
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}