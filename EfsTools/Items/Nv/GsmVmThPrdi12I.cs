using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2466)]
    [Attributes(9)]
    public sealed class GsmVmThPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}