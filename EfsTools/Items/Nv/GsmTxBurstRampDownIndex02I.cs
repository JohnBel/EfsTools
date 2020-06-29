using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(757)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex02
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}