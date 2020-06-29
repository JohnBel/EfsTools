using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2336)]
    [Attributes(9)]
    public sealed class GsmVlTlPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}