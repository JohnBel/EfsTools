using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6704)]
    [Attributes(9)]
    public sealed class LteB1RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}