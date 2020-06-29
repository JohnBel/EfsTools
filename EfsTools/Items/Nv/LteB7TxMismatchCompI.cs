using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6819)]
    [Attributes(9)]
    public sealed class LteB7TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}