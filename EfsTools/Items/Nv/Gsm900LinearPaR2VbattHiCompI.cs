using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6371)]
    [Attributes(9)]
    public sealed class Gsm900LinearPaR2VbattHiComp
    {
        public short Value { get; set; }
    }
}