using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(755)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex00
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}