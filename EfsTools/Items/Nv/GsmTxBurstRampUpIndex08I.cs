using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(748)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex08
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}