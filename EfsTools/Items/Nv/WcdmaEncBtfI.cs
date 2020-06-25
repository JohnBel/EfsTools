using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(545)]
    [Attributes(9)]
    public sealed class WcdmaEncBtf
    {
        public int Value { get; set; }
    }
}