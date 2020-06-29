using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2374)]
    [Attributes(9)]
    public sealed class GsmVhTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}