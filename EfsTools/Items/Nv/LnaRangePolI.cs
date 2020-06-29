using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(156)]
    [Attributes(9)]
    public sealed class LnaRangePol
    {
        public byte Value { get; set; }
    }
}