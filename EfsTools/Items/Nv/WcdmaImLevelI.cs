using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(521)]
    [Attributes(9)]
    public sealed class WcdmaImLevel
    {
        public short Value { get; set; }
    }
}