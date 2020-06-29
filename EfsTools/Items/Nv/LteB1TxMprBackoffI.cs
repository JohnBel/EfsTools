using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6723)]
    [Attributes(9)]
    public sealed class LteB1TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}