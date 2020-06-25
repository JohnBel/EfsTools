using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5917)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef1011
    {
        public uint Value { get; set; }
    }
}