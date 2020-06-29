using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(684)]
    [Attributes(9)]
    public sealed class PcsDaccGainMult
    {
        public byte Value { get; set; }
    }
}