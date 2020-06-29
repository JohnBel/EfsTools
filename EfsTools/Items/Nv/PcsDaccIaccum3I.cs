using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(656)]
    [Attributes(9)]
    public sealed class PcsDaccIaccum3
    {
        public byte Value { get; set; }
    }
}