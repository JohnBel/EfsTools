using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2355)]
    [Attributes(9)]
    public sealed class GsmVmTlPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}