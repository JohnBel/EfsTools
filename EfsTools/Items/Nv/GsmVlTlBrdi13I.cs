using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2161)]
    [Attributes(9)]
    public sealed class GsmVlTlBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}