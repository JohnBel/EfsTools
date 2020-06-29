using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2092)]
    [Attributes(9)]
    public sealed class GsmPrui06
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}