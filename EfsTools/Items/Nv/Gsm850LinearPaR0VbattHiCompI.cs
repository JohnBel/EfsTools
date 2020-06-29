using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6359)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR0VbattHiComp
    {
        public short Value { get; set; }
    }
}