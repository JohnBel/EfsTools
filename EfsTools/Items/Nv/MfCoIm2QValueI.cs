using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3643)]
    [Attributes(9)]
    public sealed class MfCoIm2QValue
    {
        public byte Value { get; set; }
    }
}