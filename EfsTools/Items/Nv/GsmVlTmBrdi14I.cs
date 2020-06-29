using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2214)]
    [Attributes(9)]
    public sealed class GsmVlTmBrdi14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}