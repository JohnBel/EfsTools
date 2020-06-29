using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2464)]
    [Attributes(9)]
    public sealed class GsmVmThPrdi14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}