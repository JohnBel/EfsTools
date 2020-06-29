using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3070)]
    [Attributes(9)]
    public sealed class GsmPaEnStop
    {
        public short Value { get; set; }
    }
}