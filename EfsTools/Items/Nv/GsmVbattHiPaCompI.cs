using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(806)]
    [Attributes(9)]
    public sealed class GsmVbattHiPaComp
    {
        public byte Value { get; set; }
    }
}