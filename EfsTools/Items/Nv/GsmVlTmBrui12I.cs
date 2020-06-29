using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2213)]
    [Attributes(9)]
    public sealed class GsmVlTmBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}