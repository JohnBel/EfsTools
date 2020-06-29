using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6370)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR2VbattLoComp
    {
        public short Value { get; set; }
    }
}