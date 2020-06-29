using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(753)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}