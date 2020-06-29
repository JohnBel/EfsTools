using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6543)]
    [Attributes(9)]
    public sealed class LteB7RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}