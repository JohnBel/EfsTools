using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2160)]
    [Attributes(9)]
    public sealed class GsmVlTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}