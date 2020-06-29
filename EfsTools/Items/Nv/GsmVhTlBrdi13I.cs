using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2197)]
    [Attributes(9)]
    public sealed class GsmVhTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}