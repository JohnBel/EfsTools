using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2376)]
    [Attributes(9)]
    public sealed class GsmVhTlPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}