using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2212)]
    [Attributes(9)]
    public sealed class GsmVlTmBrui13
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}