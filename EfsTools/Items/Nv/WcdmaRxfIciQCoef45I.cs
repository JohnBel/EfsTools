using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5922)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef45
    {
        public uint Value { get; set; }
    }
}