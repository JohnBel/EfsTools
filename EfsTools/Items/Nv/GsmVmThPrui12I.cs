using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2463)]
    [Attributes(9)]
    public sealed class GsmVmThPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}