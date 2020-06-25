using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5915)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef67
    {
        public uint Value { get; set; }
    }
}