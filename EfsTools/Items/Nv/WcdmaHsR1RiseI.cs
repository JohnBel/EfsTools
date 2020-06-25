using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2724)]
    [Attributes(9)]
    public sealed class WcdmaHsR1Rise
    {
        public short Value { get; set; }
    }
}