using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6604)]
    [Attributes(9)]
    public sealed class LteB17RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}