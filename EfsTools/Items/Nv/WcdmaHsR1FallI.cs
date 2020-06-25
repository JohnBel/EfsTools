using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2725)]
    [Attributes(9)]
    public sealed class WcdmaHsR1Fall
    {
        public short Value { get; set; }
    }
}