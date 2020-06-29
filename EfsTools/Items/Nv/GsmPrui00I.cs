using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2086)]
    [Attributes(9)]
    public sealed class GsmPrui00
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}