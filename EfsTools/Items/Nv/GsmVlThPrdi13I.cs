using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2447)]
    [Attributes(9)]
    public sealed class GsmVlThPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}