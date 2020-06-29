using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5386)]
    [Attributes(9)]
    public sealed class Gsm900EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}