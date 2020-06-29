using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6372)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR3VbattLoComp
    {
        public short Value { get; set; }
    }
}