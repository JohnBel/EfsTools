using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5913)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef23
    {
        public uint Value { get; set; }
    }
}