using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5921)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef23
    {
        public uint Value { get; set; }
    }
}