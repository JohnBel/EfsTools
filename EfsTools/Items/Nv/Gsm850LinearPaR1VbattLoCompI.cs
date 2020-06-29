using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6360)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR1VbattLoComp
    {
        public short Value { get; set; }
    }
}