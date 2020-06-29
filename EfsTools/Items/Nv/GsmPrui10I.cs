using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2096)]
    [Attributes(9)]
    public sealed class GsmPrui10
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}