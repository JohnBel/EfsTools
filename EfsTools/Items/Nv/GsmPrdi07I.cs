using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2104)]
    [Attributes(9)]
    public sealed class GsmPrdi07
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}