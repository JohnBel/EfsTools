using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(445)]
    [Attributes(9)]
    public sealed class PcsEncBtf
    {
        public uint Value { get; set; }
    }
}