using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5916)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef89
    {
        public uint Value { get; set; }
    }
}