using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(818)]
    [Attributes(9)]
    public sealed class HdrReceiveDiversity
    {
        public sbyte Value { get; set; }
    }
}