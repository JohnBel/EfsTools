using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5387)]
    [Attributes(9)]
    public sealed class Gsm850EdgePaUltraLoToLo
    {
        public ushort Value { get; set; }
    }
}