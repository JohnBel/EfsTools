using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6593)]
    [Attributes(9)]
    public sealed class LteB7C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}