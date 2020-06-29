using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5357)]
    [Attributes(9)]
    public sealed class Gsm1900PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}