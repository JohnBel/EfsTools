using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6681)]
    [Attributes(9)]
    public sealed class LteB40TxGainIndex3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}