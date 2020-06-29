using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2501)]
    [Attributes(9)]
    public sealed class GsmPrui11
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}