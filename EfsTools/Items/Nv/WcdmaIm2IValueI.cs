using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(869)]
    [Attributes(9)]
    public sealed class WcdmaIm2IValue
    {
        public byte Value { get; set; }
    }
}