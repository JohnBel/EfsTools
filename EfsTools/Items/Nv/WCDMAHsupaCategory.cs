using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4210)]
    [Attributes(9)]
    public sealed class WcdmaHsupaCategory
    {
        public byte Value { get; set; }
    }
}