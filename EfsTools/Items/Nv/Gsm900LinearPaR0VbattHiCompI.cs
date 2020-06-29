using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6367)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR0VbattHiComp
    {
        public short Value { get; set; }
    }
}