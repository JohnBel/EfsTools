using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(747)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex07
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}