using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6500)]
    [Attributes(9)]
    public sealed class LteB13RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}