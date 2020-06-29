using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4179)]
    [Attributes(9)]
    public sealed class GsmTxRsbCorr
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}