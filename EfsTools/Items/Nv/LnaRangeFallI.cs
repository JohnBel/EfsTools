using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(158)]
    [Attributes(9)]
    public sealed class LnaRangeFall
    {
        public sbyte Value { get; set; }
    }
}