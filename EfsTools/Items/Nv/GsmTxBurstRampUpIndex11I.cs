using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(751)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex11
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}