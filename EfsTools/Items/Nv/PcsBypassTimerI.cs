using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(391)]
    [Attributes(9)]
    public sealed class PcsBypassTimer
    {
        public byte Value { get; set; }
    }
}