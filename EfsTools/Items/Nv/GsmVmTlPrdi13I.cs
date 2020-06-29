using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2357)]
    [Attributes(9)]
    public sealed class GsmVmTlPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}