using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6368)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR1VbattLoComp
    {
        public short Value { get; set; }
    }
}