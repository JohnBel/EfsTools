using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(396)]
    [Attributes(9)]
    public sealed class PcsAgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}