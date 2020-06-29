using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6648)]
    [Attributes(9)]
    public sealed class LteB40RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}