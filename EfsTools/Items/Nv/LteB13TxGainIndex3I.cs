using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6525)]
    [Attributes(9)]
    public sealed class LteB13TxGainIndex3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}