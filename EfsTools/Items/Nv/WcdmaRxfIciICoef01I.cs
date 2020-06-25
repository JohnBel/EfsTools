using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5912)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef01
    {
        public uint Value { get; set; }
    }
}