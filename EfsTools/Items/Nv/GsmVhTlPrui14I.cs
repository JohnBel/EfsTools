using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2371)]
    [Attributes(9)]
    public sealed class GsmVhTlPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}