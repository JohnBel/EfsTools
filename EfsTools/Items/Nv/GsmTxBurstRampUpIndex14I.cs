using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(754)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}