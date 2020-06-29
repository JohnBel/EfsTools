using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6634)]
    [Attributes(9)]
    public sealed class LteB17Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}