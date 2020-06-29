using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6708)]
    [Attributes(9)]
    public sealed class LteB1RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}