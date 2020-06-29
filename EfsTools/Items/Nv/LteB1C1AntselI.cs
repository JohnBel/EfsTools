using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6739)]
    [Attributes(9)]
    public sealed class LteB1C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}