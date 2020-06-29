using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6592)]
    [Attributes(9)]
    public sealed class LteB7C1Im2Values
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}