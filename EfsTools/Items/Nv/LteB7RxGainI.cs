using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6547)]
    [Attributes(9)]
    public sealed class LteB7RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}