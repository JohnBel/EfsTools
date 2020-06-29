using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(296)]
    [Attributes(9)]
    public sealed class OtaSpSpcChange
    {
        public byte Value { get; set; }
    }
}