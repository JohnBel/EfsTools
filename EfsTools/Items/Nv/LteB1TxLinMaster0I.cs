using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6726)]
    [Attributes(9)]
    public sealed class LteB1TxLinMaster0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}