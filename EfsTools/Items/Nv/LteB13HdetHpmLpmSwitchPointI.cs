using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7227)]
    [Attributes(9)]
    public sealed class LteB13HdetHpmLpmSwitchPoint
    {
        public ushort Value { get; set; }
    }
}