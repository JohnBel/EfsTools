using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3642)]
    [Attributes(9)]
    public sealed class MfCoIm2IValue
    {
        public byte Value { get; set; }
    }
}