using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2102)]
    [Attributes(9)]
    public sealed class GsmPrdi05
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}