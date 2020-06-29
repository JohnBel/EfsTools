using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6738)]
    [Attributes(9)]
    public sealed class LteB1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}