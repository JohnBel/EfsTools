using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2196)]
    [Attributes(9)]
    public sealed class GsmVhTlBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}