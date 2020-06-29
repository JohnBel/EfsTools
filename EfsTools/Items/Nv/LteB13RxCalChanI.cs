using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6490)]
    [Attributes(9)]
    public sealed class LteB13RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}