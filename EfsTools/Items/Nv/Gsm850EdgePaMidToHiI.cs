using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5389)]
    [Attributes(9)]
    public sealed class Gsm850EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}