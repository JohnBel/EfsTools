using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5920)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciQCoef01
    {
        public uint Value { get; set; }
    }
}