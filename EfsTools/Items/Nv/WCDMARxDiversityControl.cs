using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3851)]
    [Attributes(9)]
    public sealed class WcdmaRxDiversityControl
    {
        public byte Value { get; set; }
    }
}