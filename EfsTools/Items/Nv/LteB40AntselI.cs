using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6686)]
    [Attributes(9)]
    public sealed class LteB40Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}