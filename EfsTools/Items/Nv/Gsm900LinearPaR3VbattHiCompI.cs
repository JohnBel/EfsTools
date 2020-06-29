using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6373)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR3VbattHiComp
    {
        public short Value { get; set; }
    }
}