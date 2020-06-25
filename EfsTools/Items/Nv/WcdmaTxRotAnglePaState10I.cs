using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1797)]
    [Attributes(9)]
    public sealed class WcdmaTxRotAnglePaState10
    {
        public ushort Value { get; set; }
    }
}