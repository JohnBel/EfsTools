using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(159)]
    [Attributes(9)]
    public sealed class LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}