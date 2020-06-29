using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6376)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR1VbattLoComp
    {
        public short Value { get; set; }
    }
}