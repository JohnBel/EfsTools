using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2247)]
    [Attributes(9)]
    public sealed class GsmVhTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}