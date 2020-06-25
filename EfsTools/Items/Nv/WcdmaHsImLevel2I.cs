using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4783)]
    [Attributes(9)]
    public sealed class WcdmaHsImLevel2
    {
        public short Value { get; set; }
    }
}