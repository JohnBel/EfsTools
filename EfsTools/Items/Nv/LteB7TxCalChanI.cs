using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6563)]
    [Attributes(9)]
    public sealed class LteB7TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}