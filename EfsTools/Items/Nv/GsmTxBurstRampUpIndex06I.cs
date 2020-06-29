using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(746)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex06
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}