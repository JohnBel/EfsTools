using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1875)]
    [Attributes(9)]
    public sealed class PaRMap
    {
        public byte Value { get; set; }
    }
}