using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5914)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef45
    {
        public uint Value { get; set; }
    }
}