using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5384)]
    [Attributes(9)]
    public sealed class Gsm900EdgePaUltraLoToLo
    {
        public ushort Value { get; set; }
    }
}