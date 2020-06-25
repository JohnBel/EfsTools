using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5923)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef67
    {
        public uint Value { get; set; }
    }
}