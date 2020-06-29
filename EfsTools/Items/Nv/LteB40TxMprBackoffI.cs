using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6671)]
    [Attributes(9)]
    public sealed class LteB40TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}