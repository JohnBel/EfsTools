using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2088)]
    [Attributes(9)]
    public sealed class GsmPrui02
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}