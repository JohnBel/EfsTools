using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1795)]
    [Attributes(9)]
    public sealed class WcdmaTxRotAnglePaState00
    {
        public ushort Value { get; set; }
    }
}