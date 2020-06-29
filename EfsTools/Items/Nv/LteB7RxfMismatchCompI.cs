using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6551)]
    [Attributes(9)]
    public sealed class LteB7RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}