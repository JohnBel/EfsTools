using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2090)]
    [Attributes(9)]
    public sealed class GsmPrui04
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}