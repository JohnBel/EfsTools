using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6820)]
    [Attributes(9)]
    public sealed class LteB17TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}