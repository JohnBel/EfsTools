using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6523)]
    [Attributes(9)]
    public sealed class LteB13TxGainIndex1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}