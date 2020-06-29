using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(765)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex10
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}