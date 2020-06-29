using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(336)]
    [Attributes(9)]
    public sealed class PcsHdetSpn
    {
        public byte Value { get; set; }
    }
}