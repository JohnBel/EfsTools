using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2250)]
    [Attributes(9)]
    public sealed class GsmVhTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}