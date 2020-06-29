using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2216)]
    [Attributes(9)]
    public sealed class GsmVlTmBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}