using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5896)]
    [Attributes(9)]
    public sealed class WcdmaRxfMisCompACoeff
    {
        public short Value { get; set; }
    }
}