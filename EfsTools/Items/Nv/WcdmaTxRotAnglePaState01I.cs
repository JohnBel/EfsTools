using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1796)]
    [Attributes(9)]
    public sealed class WcdmaTxRotAnglePaState01
    {
        public ushort Value { get; set; }
    }
}