using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6596)]
    [Attributes(9)]
    public sealed class LteB17RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}