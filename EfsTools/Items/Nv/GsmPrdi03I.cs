using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2100)]
    [Attributes(9)]
    public sealed class GsmPrdi03
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}