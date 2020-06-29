using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(846)]
    [Attributes(9)]
    public sealed class LnaBypassTimer3
    {
        public ushort Value { get; set; }
    }
}