using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4869)]
    [Attributes(9)]
    public sealed class GsmCarrierSuppression
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}