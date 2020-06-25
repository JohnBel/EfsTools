using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5897)]
    [Attributes(9)]
    public sealed class WcdmaRxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}