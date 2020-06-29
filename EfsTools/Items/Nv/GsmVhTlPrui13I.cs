using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2372)]
    [Attributes(9)]
    public sealed class GsmVhTlPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}