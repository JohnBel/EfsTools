using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6365)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR3VbattHiComp
    {
        public short Value { get; set; }
    }
}