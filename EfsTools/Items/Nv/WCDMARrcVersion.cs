using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3649)]
    [Attributes(9)]
    public sealed class WcdmaRrcVersion
    {
        public byte Value { get; set; }
    }
}