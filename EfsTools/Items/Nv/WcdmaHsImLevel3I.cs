using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4784)]
    [Attributes(9)]
    public sealed class WcdmaHsImLevel3
    {
        public short Value { get; set; }
    }
}