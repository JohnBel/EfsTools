using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(690)]
    [Attributes(9)]
    public sealed class PcsIm2QValue
    {
        public byte Value { get; set; }
    }
}