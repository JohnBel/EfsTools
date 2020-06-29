using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6818)]
    [Attributes(9)]
    public sealed class LteB13TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}