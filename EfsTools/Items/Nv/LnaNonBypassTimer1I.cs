using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(840)]
    [Attributes(9)]
    public sealed class LnaNonBypassTimer1
    {
        public ushort Value { get; set; }
    }
}