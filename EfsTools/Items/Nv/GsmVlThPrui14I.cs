using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2443)]
    [Attributes(9)]
    public sealed class GsmVlThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}