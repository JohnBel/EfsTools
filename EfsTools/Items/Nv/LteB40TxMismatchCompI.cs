using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6821)]
    [Attributes(9)]
    public sealed class LteB40TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}