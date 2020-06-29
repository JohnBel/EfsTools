using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6697)]
    [Attributes(9)]
    public sealed class LteB40C1RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}