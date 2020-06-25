using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(870)]
    [Attributes(9)]
    public sealed class WcdmaIm2QValue
    {
        public byte Value { get; set; }
    }
}