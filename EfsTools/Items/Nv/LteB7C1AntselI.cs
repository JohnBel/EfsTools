using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6582)]
    [Attributes(9)]
    public sealed class LteB7C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}