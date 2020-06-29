using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(761)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex06
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}