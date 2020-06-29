using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6625)]
    [Attributes(9)]
    public sealed class LteB17TxLinMaster3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}