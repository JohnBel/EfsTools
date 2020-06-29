using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2340)]
    [Attributes(9)]
    public sealed class GsmVlTlPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}