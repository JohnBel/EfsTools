using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(538)]
    [Attributes(9)]
    public sealed class WcdmaR1Fall
    {
        public ushort Value { get; set; }
    }
}