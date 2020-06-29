using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2770)]
    [Attributes(9)]
    public sealed class GsmPolarPathDelay
    {
        public short Value { get; set; }
    }
}