using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6581)]
    [Attributes(9)]
    public sealed class LteB7Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}