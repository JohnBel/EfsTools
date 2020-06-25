using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1985)]
    [Attributes(9)]
    public sealed class WcdmaRxDelay
    {
        public short Value { get; set; }
    }
}