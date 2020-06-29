using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3645)]
    [Attributes(9)]
    public sealed class MfC1Im2IValue
    {
        public byte Value { get; set; }
    }
}