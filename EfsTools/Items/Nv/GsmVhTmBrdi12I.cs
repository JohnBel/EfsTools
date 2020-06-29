using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2252)]
    [Attributes(9)]
    public sealed class GsmVhTmBrdi12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}