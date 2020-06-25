using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4067)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxRotAnglePaState00
    {
        public ushort Value { get; set; }
    }
}