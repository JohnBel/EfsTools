using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(842)]
    [Attributes(9)]
    public sealed class LnaNonBypassTimer3
    {
        public ushort Value { get; set; }
    }
}