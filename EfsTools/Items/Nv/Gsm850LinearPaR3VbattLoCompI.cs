using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6364)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR3VbattLoComp
    {
        public short Value { get; set; }
    }
}