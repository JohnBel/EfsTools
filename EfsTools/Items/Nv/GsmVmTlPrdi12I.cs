using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2358)]
    [Attributes(9)]
    public sealed class GsmVmTlPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}