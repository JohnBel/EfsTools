using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2354)]
    [Attributes(9)]
    public sealed class GsmVmTlPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}