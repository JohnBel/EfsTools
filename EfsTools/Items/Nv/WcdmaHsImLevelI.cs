using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4786)]
    [Attributes(9)]
    public sealed class WcdmaHsImLevel
    {
        public short Value { get; set; }
    }
}