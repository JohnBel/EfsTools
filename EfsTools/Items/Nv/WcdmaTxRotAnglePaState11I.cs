using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1798)]
    [Attributes(9)]
    public sealed class WcdmaTxRotAnglePaState11
    {
        public ushort Value { get; set; }
    }
}