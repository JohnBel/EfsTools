using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(376)]
    [Attributes(9)]
    public sealed class LnaRange2Rise
    {
        public sbyte Value { get; set; }
    }
}