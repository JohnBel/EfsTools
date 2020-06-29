using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(742)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex02
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}