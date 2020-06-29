using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6366)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR0VbattLoComp
    {
        public short Value { get; set; }
    }
}