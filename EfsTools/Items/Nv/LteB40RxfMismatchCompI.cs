using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6656)]
    [Attributes(9)]
    public sealed class LteB40RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}