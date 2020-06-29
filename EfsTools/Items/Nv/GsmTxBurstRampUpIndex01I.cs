using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(741)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampUpIndex01
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}