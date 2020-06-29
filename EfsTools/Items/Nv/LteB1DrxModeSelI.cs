using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6754)]
    [Attributes(9)]
    public sealed class LteB1DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}