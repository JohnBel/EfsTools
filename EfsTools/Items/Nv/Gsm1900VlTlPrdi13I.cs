using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2352)]
    [Attributes(9)]
    public sealed class Gsm1900VlTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}