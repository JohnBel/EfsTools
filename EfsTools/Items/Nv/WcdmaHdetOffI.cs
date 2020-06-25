using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(543)]
    [Attributes(9)]
    public sealed class WcdmaHdetOff
    {
        public byte Value { get; set; }
    }
}