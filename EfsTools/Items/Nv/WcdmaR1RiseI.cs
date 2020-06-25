using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(537)]
    [Attributes(9)]
    public sealed class WcdmaR1Rise
    {
        public ushort Value { get; set; }
    }
}