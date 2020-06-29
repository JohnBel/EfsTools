using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2215)]
    [Attributes(9)]
    public sealed class GsmVlTmBrdi13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}