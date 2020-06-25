using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1347)]
    [Attributes(9)]
    public sealed class WcdmaPaGainUpTime
    {
        public ushort Value { get; set; }
    }
}