using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6688)]
    [Attributes(9)]
    public sealed class LteB40C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}