using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2356)]
    [Attributes(9)]
    public sealed class GsmVmTlPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}