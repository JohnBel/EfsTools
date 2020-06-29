using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(743)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex03
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}