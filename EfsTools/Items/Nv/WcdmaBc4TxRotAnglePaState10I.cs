using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4069)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxRotAnglePaState10
    {
        public ushort Value { get; set; }
    }
}