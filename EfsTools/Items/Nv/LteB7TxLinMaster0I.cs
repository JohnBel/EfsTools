using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6569)]
    [Attributes(9)]
    public sealed class LteB7TxLinMaster0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}