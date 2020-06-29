using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6685)]
    [Attributes(9)]
    public sealed class LteB40HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}