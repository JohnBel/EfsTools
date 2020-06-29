using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2465)]
    [Attributes(9)]
    public sealed class GsmVmThPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}