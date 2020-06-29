using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(660)]
    [Attributes(9)]
    public sealed class PcsDaccIaccum4
    {
        public byte Value { get; set; }
    }
}