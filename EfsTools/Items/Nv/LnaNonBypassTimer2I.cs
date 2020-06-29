using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(841)]
    [Attributes(9)]
    public sealed class LnaNonBypassTimer2
    {
        public ushort Value { get; set; }
    }
}