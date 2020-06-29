using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(594)]
    [Attributes(9)]
    public sealed class PcsLna3Fall
    {
        public sbyte Value { get; set; }
    }
}