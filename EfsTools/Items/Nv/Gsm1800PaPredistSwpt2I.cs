using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5370)]
    [Attributes(9)]
    public sealed class Gsm1800PaPredistSwpt2
    {
        public ushort Value { get; set; }
    }
}