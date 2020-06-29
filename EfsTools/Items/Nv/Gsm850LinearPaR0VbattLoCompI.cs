using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6358)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR0VbattLoComp
    {
        public short Value { get; set; }
    }
}