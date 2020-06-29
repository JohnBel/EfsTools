using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6512)]
    [Attributes(9)]
    public sealed class LteB13TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}