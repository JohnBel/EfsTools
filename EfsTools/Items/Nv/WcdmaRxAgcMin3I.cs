using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(873)]
    [Attributes(9)]
    public sealed class WcdmaRxAgcMin3
    {
        public short Value { get; set; }
    }
}