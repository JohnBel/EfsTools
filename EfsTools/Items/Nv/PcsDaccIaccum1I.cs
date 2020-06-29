using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(648)]
    [Attributes(9)]
    public sealed class PcsDaccIaccum1
    {
        public byte Value { get; set; }
    }
}