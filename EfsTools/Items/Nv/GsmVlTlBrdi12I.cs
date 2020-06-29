using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2162)]
    [Attributes(9)]
    public sealed class GsmVlTlBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}