using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1348)]
    [Attributes(9)]
    public sealed class WcdmaPaGainDownTime
    {
        public ushort Value { get; set; }
    }
}