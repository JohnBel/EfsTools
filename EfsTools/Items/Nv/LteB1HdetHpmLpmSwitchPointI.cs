using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7229)]
    [Attributes(9)]
    public sealed class LteB1HdetHpmLpmSwitchPoint
    {
        public ushort Value { get; set; }
    }
}