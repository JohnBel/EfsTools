using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6363)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR2VbattHiComp
    {
        public short Value { get; set; }
    }
}