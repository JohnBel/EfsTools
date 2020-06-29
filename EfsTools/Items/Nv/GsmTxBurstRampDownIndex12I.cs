using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(767)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}