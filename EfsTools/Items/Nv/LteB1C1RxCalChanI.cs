using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6749)]
    [Attributes(9)]
    public sealed class LteB1C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}