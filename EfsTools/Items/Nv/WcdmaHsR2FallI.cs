using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2727)]
    [Attributes(9)]
    public sealed class WcdmaHsR2Fall
    {
        public short Value { get; set; }
    }
}