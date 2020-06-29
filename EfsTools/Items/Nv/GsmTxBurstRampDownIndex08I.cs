using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(763)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex08
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}