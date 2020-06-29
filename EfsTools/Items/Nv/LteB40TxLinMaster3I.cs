using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6677)]
    [Attributes(9)]
    public sealed class LteB40TxLinMaster3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}