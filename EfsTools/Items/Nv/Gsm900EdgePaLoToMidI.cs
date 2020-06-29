using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5385)]
    [Attributes(9)]
    public sealed class Gsm900EdgePaLoToMid
    {
        public ushort Value { get; set; }
    }
}