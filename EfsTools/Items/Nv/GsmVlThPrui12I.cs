using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2445)]
    [Attributes(9)]
    public sealed class GsmVlThPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}