using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(544)]
    [Attributes(9)]
    public sealed class WcdmaHdetSpn
    {
        public byte Value { get; set; }
    }
}