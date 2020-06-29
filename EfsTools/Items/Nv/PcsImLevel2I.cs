using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(393)]
    [Attributes(9)]
    public sealed class PcsImLevel2
    {
        public byte Value { get; set; }
    }
}