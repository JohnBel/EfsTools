using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1138)]
    [Attributes(9)]
    public sealed class Gsm850VbattHiPaComp
    {
        public byte Value { get; set; }
    }
}