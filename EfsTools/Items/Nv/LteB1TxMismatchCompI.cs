using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6822)]
    [Attributes(9)]
    public sealed class LteB1TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}