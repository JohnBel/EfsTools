using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5369)]
    [Attributes(9)]
    public sealed class Gsm1800PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}