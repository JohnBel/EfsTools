using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5355)]
    [Attributes(9)]
    public sealed class Gsm1800PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}