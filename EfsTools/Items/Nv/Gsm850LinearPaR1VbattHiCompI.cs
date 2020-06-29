using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6361)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR1VbattHiComp
    {
        public short Value { get; set; }
    }
}