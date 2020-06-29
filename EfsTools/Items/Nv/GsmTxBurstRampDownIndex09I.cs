using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(764)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex09
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}