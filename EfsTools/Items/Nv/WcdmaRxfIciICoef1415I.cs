using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5919)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciICoef1415
    {
        public uint Value { get; set; }
    }
}