using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6515)]
    [Attributes(9)]
    public sealed class LteB13TxMprBackoff
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}