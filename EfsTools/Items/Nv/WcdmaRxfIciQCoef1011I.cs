using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5925)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef1011
    {
        public uint Value { get; set; }
    }
}