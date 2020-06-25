using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2018)]
    [Attributes(9)]
    public sealed class WcdmaR2Fall
    {
        public ushort Value { get; set; }
    }
}