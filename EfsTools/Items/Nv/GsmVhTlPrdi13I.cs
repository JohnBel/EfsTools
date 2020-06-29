using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2375)]
    [Attributes(9)]
    public sealed class GsmVhTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}