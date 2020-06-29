using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5372)]
    [Attributes(9)]
    public sealed class Gsm1900PaPredistSwpt2
    {
        public ushort Value { get; set; }
    }
}