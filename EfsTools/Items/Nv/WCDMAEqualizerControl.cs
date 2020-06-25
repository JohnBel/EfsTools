using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3852)]
    [Attributes(9)]
    public sealed class WcdmaEqualizerControl
    {
        public byte Value { get; set; }
    }
}