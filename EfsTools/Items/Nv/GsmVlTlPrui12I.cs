using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2337)]
    [Attributes(9)]
    public sealed class GsmVlTlPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}