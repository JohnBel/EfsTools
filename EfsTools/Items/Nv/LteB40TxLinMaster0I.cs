using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6674)]
    [Attributes(9)]
    public sealed class LteB40TxLinMaster0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}