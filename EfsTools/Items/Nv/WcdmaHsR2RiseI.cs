using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2726)]
    [Attributes(9)]
    public sealed class WcdmaHsR2Rise
    {
        public short Value { get; set; }
    }
}