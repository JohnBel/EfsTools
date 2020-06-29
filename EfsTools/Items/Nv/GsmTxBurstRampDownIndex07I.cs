using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(762)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex07
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}