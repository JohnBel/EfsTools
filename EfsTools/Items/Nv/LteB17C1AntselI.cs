using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6635)]
    [Attributes(9)]
    public sealed class LteB17C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}