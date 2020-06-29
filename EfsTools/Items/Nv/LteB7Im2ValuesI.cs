using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6550)]
    [Attributes(9)]
    public sealed class LteB7Im2Values
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}