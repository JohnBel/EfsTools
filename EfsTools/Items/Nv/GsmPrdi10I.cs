using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2107)]
    [Attributes(9)]
    public sealed class GsmPrdi10
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}