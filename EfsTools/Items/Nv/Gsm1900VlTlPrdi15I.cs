using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2350)]
    [Attributes(9)]
    public sealed class Gsm1900VlTlPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}