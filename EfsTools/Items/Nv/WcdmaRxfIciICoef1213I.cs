using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5918)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef1213
    {
        public uint Value { get; set; }
    }
}