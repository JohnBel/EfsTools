using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6362)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR2VbattLoComp
    {
        public short Value { get; set; }
    }
}