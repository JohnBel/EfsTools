using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5388)]
    [Attributes(9)]
    public sealed class Gsm850EdgePaLoToMid
    {
        public ushort Value { get; set; }
    }
}