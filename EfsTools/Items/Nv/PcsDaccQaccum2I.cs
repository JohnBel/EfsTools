using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(672)]
    [Attributes(9)]
    public sealed class PcsDaccQaccum2
    {
        public byte Value { get; set; }
    }
}