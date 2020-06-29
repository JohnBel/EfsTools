using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(768)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}