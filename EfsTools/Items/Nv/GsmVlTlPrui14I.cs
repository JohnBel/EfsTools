using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2335)]
    [Attributes(9)]
    public sealed class GsmVlTlPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}