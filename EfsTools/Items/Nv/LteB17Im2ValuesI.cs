using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6603)]
    [Attributes(9)]
    public sealed class LteB17Im2Values
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}