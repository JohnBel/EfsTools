using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4070)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxRotAnglePaState11
    {
        public ushort Value { get; set; }
    }
}