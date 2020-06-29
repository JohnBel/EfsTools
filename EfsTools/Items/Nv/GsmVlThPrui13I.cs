using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2444)]
    [Attributes(9)]
    public sealed class GsmVlThPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}