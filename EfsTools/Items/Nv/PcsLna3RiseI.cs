using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(596)]
    [Attributes(9)]
    public sealed class PcsLna3Rise
    {
        public sbyte Value { get; set; }
    }
}