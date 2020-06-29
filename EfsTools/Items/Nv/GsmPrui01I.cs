using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2087)]
    [Attributes(9)]
    public sealed class GsmPrui01
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}