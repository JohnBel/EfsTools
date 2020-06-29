using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5356)]
    [Attributes(9)]
    public sealed class Gsm1800PaR2ToR4
    {
        public ushort Value { get; set; }
    }
}