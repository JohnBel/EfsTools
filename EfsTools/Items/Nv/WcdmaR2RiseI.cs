using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2017)]
    [Attributes(9)]
    public sealed class WcdmaR2Rise
    {
        public ushort Value { get; set; }
    }
}