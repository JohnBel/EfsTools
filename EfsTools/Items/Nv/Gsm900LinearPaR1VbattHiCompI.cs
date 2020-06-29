using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6369)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR1VbattHiComp
    {
        public short Value { get; set; }
    }
}