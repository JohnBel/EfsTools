using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6572)]
    [Attributes(9)]
    public sealed class LteB7TxLinMaster3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}