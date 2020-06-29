using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2106)]
    [Attributes(9)]
    public sealed class GsmPrdi09
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}