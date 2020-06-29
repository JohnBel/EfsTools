using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6620)]
    [Attributes(9)]
    public sealed class LteB17TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}