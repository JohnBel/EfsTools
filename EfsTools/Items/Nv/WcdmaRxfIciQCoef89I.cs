using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5924)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef89
    {
        public uint Value { get; set; }
    }
}