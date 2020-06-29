using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2108)]
    [Attributes(9)]
    public sealed class GsmPrdi11
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}