using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2461)]
    [Attributes(9)]
    public sealed class GsmVmThPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}