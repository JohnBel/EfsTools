using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5358)]
    [Attributes(9)]
    public sealed class Gsm1900PaR2ToR4
    {
        public ushort Value { get; set; }
    }
}