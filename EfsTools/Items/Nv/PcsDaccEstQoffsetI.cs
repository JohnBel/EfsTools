using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(640)]
    [Attributes(9)]
    public sealed class PcsDaccEstQoffset
    {
        public uint Value { get; set; }
    }
}