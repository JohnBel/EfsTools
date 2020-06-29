using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6740)]
    [Attributes(9)]
    public sealed class LteB1C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}