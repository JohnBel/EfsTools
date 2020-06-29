using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6616)]
    [Attributes(9)]
    public sealed class LteB17TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}