using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2353)]
    [Attributes(9)]
    public sealed class GsmVmTlPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}