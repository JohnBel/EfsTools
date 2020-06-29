using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2338)]
    [Attributes(9)]
    public sealed class GsmVlTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}