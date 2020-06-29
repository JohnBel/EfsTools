using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2249)]
    [Attributes(9)]
    public sealed class GsmVhTmBrui12
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}