using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2339)]
    [Attributes(9)]
    public sealed class GsmVlTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}