using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4068)]
    [Attributes(9)]
    public sealed class WcdmaBc4TxRotAnglePaState01
    {
        public ushort Value { get; set; }
    }
}