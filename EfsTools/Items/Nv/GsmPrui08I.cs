using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2094)]
    [Attributes(9)]
    public sealed class GsmPrui08
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}