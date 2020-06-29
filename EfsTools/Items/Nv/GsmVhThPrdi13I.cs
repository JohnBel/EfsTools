using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2483)]
    [Attributes(9)]
    public sealed class GsmVhThPrdi13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}