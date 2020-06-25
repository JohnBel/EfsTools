using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(872)]
    [Attributes(9)]
    public sealed class WcdmaRxAgcMin2
    {
        public short Value { get; set; }
    }
}