using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6678)]
    [Attributes(9)]
    public sealed class LteB40TxGainIndex0
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}