using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(845)]
    [Attributes(9)]
    public sealed class LnaBypassTimer2
    {
        public ushort Value { get; set; }
    }
}