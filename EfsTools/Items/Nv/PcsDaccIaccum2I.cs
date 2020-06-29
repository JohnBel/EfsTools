using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(652)]
    [Attributes(9)]
    public sealed class PcsDaccIaccum2
    {
        public byte Value { get; set; }
    }
}