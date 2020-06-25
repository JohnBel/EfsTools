using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(523)]
    [Attributes(9)]
    public sealed class WcdmaBypassTimer
    {
        public ushort Value { get; set; }
    }
}