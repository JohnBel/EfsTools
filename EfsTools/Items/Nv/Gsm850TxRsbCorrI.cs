using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4181)]
    [Attributes(9)]
    public sealed class Gsm850TxRsbCorr
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}