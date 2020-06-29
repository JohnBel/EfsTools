using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2772)]
    [Attributes(9)]
    public sealed class Gsm850PolarPathDelay
    {
        public short Value { get; set; }
    }
}