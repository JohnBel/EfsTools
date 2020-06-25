using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5926)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef1213
    {
        public uint Value { get; set; }
    }
}