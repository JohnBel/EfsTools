using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(839)]
    [Attributes(9)]
    public sealed class LnaNonBypassTimer0
    {
        public ushort Value { get; set; }
    }
}