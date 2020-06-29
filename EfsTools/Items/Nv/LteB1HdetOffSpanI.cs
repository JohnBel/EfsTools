using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6737)]
    [Attributes(9)]
    public sealed class LteB1HdetOffSpan
    {
        [FieldCount(2)]
        public ushort[] Value { get; set; }
    }
}